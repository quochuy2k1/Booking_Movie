import moment from "moment";
import React, { useCallback, useEffect, useMemo } from "react";
import { useState } from "react";
import { QrReader } from "react-qr-reader";
import { Container, Header, Item, Label, Image, Grid, Button, Placeholder, Card } from "semantic-ui-react";
import { GetBookingByQrCode, GetReportBookingByQrCode } from "../../../../../services/user.service";
import { IHistoryBookingState } from "../../../../../client/features/user/BookingHistory";
import classNames from "classnames";
import { useAppDispatch, useAppSelector } from "../../../../../app/hooks";
import { UpdatePaymentStatusAsync } from "../../../../../slices/bookings/BookingSlice";
import { PaymentStatusUpdateRequest } from "../../../../../services/booking.service";
const url = `${import.meta.env.VITE_REACT_APP_API_BASE!}`

export interface IQRBookingScanner extends IHistoryBookingState {
    status: boolean
}

const QRBookingScanner: React.FC = () => {
    const dispatch = useAppDispatch();
    const [data, setData] = useState<string>("")
    const [booked, setBooked] = useState<IQRBookingScanner | null>(null);
    const [fileReport, setFileReport] = useState<string | null>(null);
    const token = localStorage.getItem("token");
    const bookings = useAppSelector(state => state.booking.bookings)
    const GetBookingByQrCodeAsync = useCallback(async (qrContent: string) => {
        try {

            const token = localStorage.getItem("token")!;
            const result = await GetBookingByQrCode(encodeURIComponent(qrContent), token);
            const result_report = await GetReportBookingByQrCode(encodeURIComponent(qrContent), token);
            if (result) {
                setBooked(result.data);
            }
            if (result_report) {
                setFileReport(url + result_report.data);

            }
        } catch (error: any) {
            console.error(error.message)
        }
    }, []);

    const ReaderHandle = useMemo(() => (result: any, error: any) => {

        if (result) {
            setData(result.getText());
            GetBookingByQrCodeAsync(result.getText());
        }

        if (error) {
            console.info(error);
        }

    }, [GetBookingByQrCodeAsync])


    useEffect(() => {



    }, [])


    const HandlePaymentStatusUpdate = () => {
        const request: PaymentStatusUpdateRequest = {
            orderId: booked?.orderId,
            status: true,
            token: token!
        }
        dispatch(UpdatePaymentStatusAsync(request))
    }

    const HandleResetQRCodeScanner = () => {
        setBooked(null);
    }
    return (
        <>

            <Grid >
                <Grid.Column width={5}>
                    <Header as="h3" color="orange" >{"Nơi quét mã"}</Header>
                    <QrReader
                        onResult={ReaderHandle}
                        // scanDelay={5}
                        videoId="123"
                        ViewFinder={(props) => <svg width="50px" viewBox="0 0 100 100" fill="none" xmlns="http://www.w3.org/2000/svg" style={{ top: 0, left: 0, zIndex: 1, boxSizing: 'border-box', border: '50px solid rgba(0, 0, 0, 0.3)', position: 'absolute', width: '100%', height: '100%' }}>
                            <path fill="none" d="M13,0 L0,0 L0,13" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                            <path fill="none" d="M0,87 L0,100 L13,100" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                            <path fill="none" d="M87,100 L100,100 L100,87" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                            <path fill="none" d="M100,13 L100,0 87,0" stroke="rgba(255, 0, 0, 0.5)" strokeWidth={5} />
                        </svg>
                        }
                        constraints={{ facingMode: 'user' }}
                        containerStyle={{ width: '100%' }}
                        className="pb-4"
                    //     videoContainerStyle={{ width: "50%" }}
                    // // videoStyle={{width: "50%"}}
                    />
                    <div className="flex">
                        <Button content='Xác nhận đã quét' size="large" color="orange" fluid icon='ticket alternate' labelPosition='left' onClick={HandlePaymentStatusUpdate} />
                        <Button content='Làm mới' size="large" color="grey" fluid icon='erase' labelPosition='left' onClick={HandleResetQRCodeScanner} />
                    </div>
                </Grid.Column>

                <Grid.Column width={6}>
                    <Header as="h3" color="orange" >{"Kết quả quét"}</Header>
                    <div className={classNames("relative p-5", { "bg-gray-700": booked }, { "bg-white": !booked })} >
                        <Label as='a' color={booked?.status ? "green" : "red"} ribbon>
                            {booked?.status === true ? "Đã quét" : "Chưa quét"}
                        </Label>
                        {booked?.movieImage ? <Image src={booked?.movieImage}></Image> : <Placeholder><Placeholder.Image rectangular></Placeholder.Image></Placeholder>}
                        <Header as="h3" className="text-orange-600">{booked?.movieName}</Header>
                        <Item.Group divided>
                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white ">
                                    {booked?.orderId ? <> Mã giao dịch: {booked.orderId} </> : <Placeholder><Placeholder.Line length="full"></Placeholder.Line></Placeholder>}
                                </Item.Content>
                            </Item>
                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    {booked?.cinemaName ? <>   Rạp: {booked.cinemaName}  | {booked?.auditoriumName}</> : <Placeholder><Placeholder.Line length="medium"></Placeholder.Line></Placeholder>}
                                </Item.Content>
                            </Item>

                            <Item className="py-2">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    {booked?.showTime ? <> Suất chiếu: {moment(booked?.showTime).format("HH:mm")} | {booked?.auditoriumName}</> : <Placeholder><Placeholder.Line length="long"></Placeholder.Line></Placeholder>}
                                </Item.Content>
                            </Item>

                            <Item className="py-1">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    {booked?.bookingCombo ? <> Combo: {booked?.bookingCombo.map((combo, idx) => combo.quantity! > 0 && (<Label key={idx} className="my-1" color='teal' horizontal>
                                        {`${combo.name} (${combo.quantity})`}
                                    </Label>))}</> : <Placeholder><Placeholder.Line length="full"></Placeholder.Line></Placeholder>}
                                </Item.Content>
                            </Item>
                            <Item className="py-1">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    {booked?.bookingTicket ? <> Vé: {booked?.bookingTicket.map((ticket, idx) => ticket.quantity! > 0 && (<Label key={idx} className="my-1" color='blue' horizontal>
                                        {`${ticket.name} (${ticket.quantity})`}
                                    </Label>))}</> : <Placeholder><Placeholder.Line length="full"></Placeholder.Line></Placeholder>}
                                </Item.Content>
                            </Item>
                            <Item className="py-1">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    {booked?.bookingSeats ? <> Ghế: {booked?.bookingSeats.map((seatName, idx) => (
                                        <Label key={idx} className="my-1" color='brown' horizontal>{seatName}</Label>
                                    ))}</> : <Placeholder><Placeholder.Line length="full"></Placeholder.Line></Placeholder>}
                                </Item.Content>
                            </Item>
                            <Item className="py-1">
                                <Item.Content verticalAlign='middle' className="text-white">
                                    {booked?.total ? <> Tổng thanh toán: <Label className="my-1" color='red' horizontal>{booked?.total.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}đ</Label></> : <Placeholder><Placeholder.Line length="short"></Placeholder.Line></Placeholder>}

                                </Item.Content>
                            </Item>


                        </Item.Group>

                    </div>
                </Grid.Column>

                <Grid.Column width={5}>
                    <Header as="h3" color="orange" >{"Vé xem phim"}</Header>
                    <div style={{ overflow: 'scroll', maxHeight: '100vh', height: '60vh', marginBottom: '1rem' }}>
                        {fileReport && (
                            <embed src={`${fileReport}#toolbar=0`} type="application/pdf" width="100%" height="100%">
                        </embed>
                        )}
                    </div>
                    <div className="flex">
                        <Button content='In vé' size="large" color="green" fluid icon='print' labelPosition='left' onClick={() => {
                           if(fileReport) {
                            const w = window.open(fileReport, "_blank");
                        
                           }
                        }} />

                    </div>
                </Grid.Column>
            </Grid>
        </>


    )
}

export default QRBookingScanner;