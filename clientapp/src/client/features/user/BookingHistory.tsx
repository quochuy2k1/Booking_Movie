import { useCallback, useEffect, useState } from "react"
import { Container, Grid, Header, Item, Image, Label, Button, Icon, Popup } from "semantic-ui-react"
import { GetBookingByUser } from "../../../services/user.service";
import moment from "moment";
import { parseJwt } from "../../utils/parseJwt";
import { QRCode } from "react-qrcode-logo";
import html2canvas from "html2canvas";

interface BookingComboResponse {
    name: string,
    quantity: number,
    price: number
}
interface BookingTicketResponse {
    name: string,
    ticketTypeName: string,
    quantity: number,
    price: number
}

export interface IHistoryBookingState {
    qrContent: string,
    orderId: string,
    movieName: string,
    movieImage: string,
    cinemaName: string,
    auditoriumName: string,
    total: number,
    showTime: string,
    showDate: string,
    bookingDate: string,
    bookingCombo: BookingComboResponse[],
    bookingTicket: BookingTicketResponse[],
    bookingSeats: string[]
}


const HistoryBooking: React.FC<{}> = () => {

    const [Lstbooked, setLstBooked] = useState<IHistoryBookingState[] | null>(null);

    const GetBookingByUserAsync = useCallback(async (userId: string, token: string) => {
        try {
            const result = await GetBookingByUser(userId, token);

            if (result) {
                setLstBooked([...result.data])
            }
        } catch (error: any) {
            console.error(error.message)
        }

    }, [])

    useEffect(() => {
        var token = localStorage.getItem("token")!;

        if (token) {
            const userId = parseJwt(token).userIdClaim;
            console.log(parseJwt(token))
            GetBookingByUserAsync(userId, token);
        }
        else {

        }
    }, [GetBookingByUserAsync])

    const handleDownload = () => {
        html2canvas(document.querySelector('#react-qrcode-logo') as any)
            .then(function (canvas: HTMLCanvasElement) {
                const link = document.createElement('a');
                link.download = 'qr-booking-ticket.png';
                link.href = canvas.toDataURL();
                link.click();
            });
    }

    return (
        <Container>

            <Grid>
                {Lstbooked?.map((booked, idx) => (
                    <Grid.Column computer={4} key={idx}>
                        <div className="sticky top-0 bg-gray-700 p-5 ">
                            <Image src={booked.movieImage}></Image>
                            <Header as="h3" className="text-orange-600">{booked?.movieName}</Header>
                            <Item.Group divided>
                                <Item className="py-2">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Mã giao dịch: {booked?.orderId}
                                    </Item.Content>
                                </Item>
                                <Item className="py-2">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Rạp: {booked?.cinemaName} | {booked?.auditoriumName}
                                    </Item.Content>
                                </Item>

                                <Item className="py-2">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Suất chiếu: {`${booked.showDate ? moment(booked.showDate).format("DD/MM/yyyy"): "Lỗi"} ${moment.utc(booked?.showTime).local().format("HH:mm")}`} | {booked?.auditoriumName}
                                    </Item.Content>
                                </Item>

                                <Item className="py-1">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Combo: {booked.bookingCombo.map((combo, idx) => combo.quantity! > 0 && (<Label key={idx} className="my-1" color='teal' horizontal>
                                            {`${combo.name} (${combo.quantity})`}
                                        </Label>))}
                                    </Item.Content>
                                </Item>
                                <Item className="py-1">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Vé: {booked.bookingTicket.map((ticket, idx) => ticket.quantity! > 0 && (<Label key={idx} className="my-1" color='blue' horizontal>
                                            {`${ticket.name} (${ticket.quantity})`}
                                        </Label>))}
                                    </Item.Content>
                                </Item>
                                <Item className="py-1">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Ghế: {booked.bookingSeats.map(seatName => (
                                            <Label key={idx} className="my-1" color='brown' horizontal>{seatName}</Label>
                                        ))}
                                    </Item.Content>
                                </Item>
                                <Item className="py-1">
                                    <Item.Content verticalAlign='middle' className="text-white">
                                        Tổng thanh toán: <Label key={idx} className="my-1" color='red' horizontal>{booked.total.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}đ</Label>

                                    </Item.Content>
                                </Item>
                                <Item className="py-1">
                                    <Item.Content verticalAlign='middle' className="text-white">


                                    </Item.Content>
                                </Item>
                                <Item className="py-1">
                                    <Item.Content verticalAlign='middle' className="flex">

                                        <Popup
                                            content='I will not flip!'
                                            on='click'
                                            pinned
                                            trigger={<Button content="QR Code" color="grey" icon="qrcode" labelPosition='left'></Button>}
                                        >
                                            <Popup.Content>
                                                <div className="flex flex-col">
                                                    <QRCode value={booked.qrContent} logoWidth={38} qrStyle="squares" logoImage="/berry-logo.png" />
                                                    <Button color="orange" onClick={handleDownload} content="Tải QR" icon="download" fluid labelPosition='left'></Button>
                                                </div>
                                            </Popup.Content>
                                        </Popup>





                                    </Item.Content>
                                </Item>
                            </Item.Group>
                        </div>
                    </Grid.Column>
                ))}
            </Grid>
        </Container>
    )
}

export default HistoryBooking;