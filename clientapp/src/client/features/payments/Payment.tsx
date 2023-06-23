import React, { useCallback, useEffect } from "react";
import { Button, ButtonProps, Checkbox, DropdownProps, Form, Icon, Input, InputOnChangeData } from "semantic-ui-react";
import PaymentSelect from "../../components/common/PaymentSelect";
import "./payment.css"
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { bookPayment } from "../../../slices/bookings/BookingSliceClient";
import { BookingCombo, BookingCreateRequest, BookingTicket, CreateBooking } from "../../../services/booking.service";
import { MovieModel } from "../../../slices/movie/movieSlice";
import { parseJwt } from "../../utils/parseJwt";
import { BookingSeatNo } from '../../../slices/seats/seatReservedSlice';
import { Navigate } from "react-router-dom";
import { STATUS_MESSAGE } from "../../../common/status-message";
import Notify from 'devextreme/ui/notify';

const Payment: React.FC<{}> = () => {

    const dispatch = useAppDispatch();
    const { screening, couponId, paymentMethodId, Total, appUserId, showDate } = useAppSelector(state => state.bookingClient.booking)
    const { seatNo } = useAppSelector(state => state.seatReserved)
    const { tickets } = useAppSelector(state => state.ticket)
    const { combos } = useAppSelector(state => state.combo)

    useEffect(() => {
        console.log([screening?.id, couponId, paymentMethodId, Total, appUserId, seatNo, tickets, combos],)
    })

    const paymentMethodHandle = (e: React.SyntheticEvent<HTMLElement, Event>, data: DropdownProps) => {
        dispatch(bookPayment({ paymentMethodId: data.value as number }))
        console.log(data.value as number, "payment method value")
    }
    const couponHandle = (event: React.ChangeEvent<HTMLInputElement>, data: InputOnChangeData) => {
        dispatch(bookPayment({ couponId: Number.parseInt(data.value) }))

        console.log(data.value, "data coupon value change")
    }

    const CreateBookingAsync = useCallback(async (request: Partial<BookingCreateRequest>) =>{
        const result = await CreateBooking(request);

        return result.data;
    }, [])

    const paymentHandle = async (event: React.MouseEvent<HTMLButtonElement, MouseEvent>, data: ButtonProps) => {
        const movie_session: string | null = sessionStorage.getItem("book-movie");
        var token = localStorage.getItem("token")!;
        if(!movie_session || (movie_session === null || movie_session === 'undefined')){
            Notify({
                message: STATUS_MESSAGE["BOOK_MOVIE_FAILD"],
                // height: 45,
                width: 300,
                minWidth: 300,
                type: "warning",
                displayTime: 3500,
                animation: {
                    show: {
                        type: 'fade', duration: 400, from: 0, to: 1,
                    },
                    hide: { type: 'fade', duration: 40, to: 0 },
                },
            }, {
                position: "top left",
                direction: "down-stack",
            });
            return;
        }
        const movie: MovieModel = JSON.parse(movie_session);


        const userId = parseJwt(token).userIdClaim;
        

        const totalBookTicket: number | undefined = tickets.map(ticket => { if (ticket.total! > 0){ return ticket.total!} return ticket.total! }).reduce((pre, TotalTicket) => {

            return pre! + TotalTicket!;

        }, 0);

        const totalBookCombo: number| undefined = combos.map(combos => { if(combos.total! > 0){ return combos.total!} return combos.total! }).reduce((pre, totalCombo) => {

            return pre! + totalCombo!;

        }, 0);


        const bookingCombo = combos.filter(combo => combo.total! > 0).map(combo => ({
            comboId: Number.parseInt(combo.id),
            quantity: combo.quantity!,
            total: combo.total!,

        }) as BookingCombo)

        const bookingTicket = tickets.filter(ticket => ticket.total! > 0).map(ticket => ({
            ticketId: Number.parseInt(ticket.id),
            quantity: ticket.quantity!,
            total: ticket.total!,

        }) as BookingTicket);

        const bookingSeatNo = seatNo.map(seatNo => ({
            seatNoId: seatNo.seatNoId
        }) as Partial<BookingSeatNo>);
        console.log(bookingSeatNo, "booking seatNo")
        
        const dataRequestPayment : Partial<BookingCreateRequest> = {
            orderInfo: `Thanh toán đặt vé xem phim: "${movie.name}"`,
            amount: totalBookTicket + totalBookCombo,
            token: token,
            extraData: {
                appUserId: userId,
                couponId: couponId,
                paymentMethodId: paymentMethodId,
                screeningId: screening.movieSchedule![0].id,
                Total: totalBookTicket + totalBookCombo,
                showDate: showDate,
                bookingCombo: bookingCombo,
                bookingTicket: bookingTicket,
                bookingSeatNo: bookingSeatNo 
            }
        }

        const orderUrl  = await CreateBookingAsync(dataRequestPayment)
        console.log(dataRequestPayment, "dataRequestPayment")
        window.location.replace(orderUrl);
    }
    return (
        <>

            <div className="bg-gray-700 flex flex-col justify-center">
                <Form className="  relative pb-10 pt-5 rounded px-10 md:w-7/12 w-full mx-auto " >
                    <Form.Group grouped widths={1} className="">
                        {/* <Form.Dropdown as={} /> */}

                        <Form.Field width={16} >
                            <label className="text-white">Họ và tên</label>
                            <Input placeholder='Họ và tên' />
                        </Form.Field>
                        <Form.Field width={16}>
                            <label className="text-white">Email</label>
                            <Input type="email" placeholder='Email' />
                        </Form.Field>
                        <Form.Field width={16}>
                            <label className="text-white">Số điện thoại</label>
                            <Input type="tel" placeholder='Số điện thoại' />
                        </Form.Field>
                    </Form.Group>

                    <Form.Group grouped widths={1}>
                        <Form.Field width={16}>
                            <label className="text-white">Phương thức thanh toán</label>
                            <PaymentSelect onPaymentSelect={paymentMethodHandle} className="bg-gray-500 text-white"></PaymentSelect>
                        </Form.Field>
                        <Form.Field width={16}>
                            <label className="text-white">Mã giảm giá</label>
                            <Input type="text" placeholder='Mã giảm giá' onChange={couponHandle} />
                        </Form.Field>
                        <Form.Field width={16} className="pt-2">
                            <Button type='button' color="orange" fluid>Áp dụng</Button>
                        </Form.Field>
                    </Form.Group>
                    <Form.Group grouped widths={1}>
                        <Form.Field width={16}>
                            <Checkbox defaultChecked label="Cam kết mua vé xem phim này cho người xem ở độ tuổi quy định và tôi đã đọc và đồng ý với Điều Kiện và Điều Khoản." />

                        </Form.Field>

                    </Form.Group>
                    <Form.Group widths={2} unstackable className="justify-end">
                        <Form.Button color="orange" icon labelPosition="left" size="large" className="text-end">
                            <Icon name='arrow left' />
                            Quay lại
                        </Form.Button>
                        <Form.Button color="orange" icon labelPosition="left" size="large" onClick={paymentHandle} >
                            <Icon name='payment' />
                            Thanh toán
                        </Form.Button>

                    </Form.Group>

                </Form>
            </div>



        </>
    )
}

export default Payment;