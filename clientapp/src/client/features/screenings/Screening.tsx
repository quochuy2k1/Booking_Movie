import moment from "moment";
import React, { useCallback, useEffect, useState } from "react";
import { Link, useNavigate, useParams } from "react-router-dom";
import { Button, Grid, Header, Item } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { GetScreeningByMovieId } from "../../../services/movie.service";
import { bookScreening } from "../../../slices/bookings/BookingSlice";
import { AuditoriumScreening, MovieSchedule, ScreeningModel, addScreening } from "../../../slices/screenings/ScreeningSlice";
import { bookScreeningId } from "../../../slices/bookings/BookingSliceClient";
import { checkLogin } from "../../../slices/user/userSlice";
import { clearAllTickets } from "../../../slices/tickets/ticketSlice";
import { DateBox } from "devextreme-react";
import Notify from 'devextreme/ui/notify';
import { STATUS_MESSAGE } from "../../../common/status-message";
import { NativeEventInfo } from "devextreme/events";
import dxDateBox from "devextreme/ui/date_box";
import { ValueChangedInfo } from "devextreme/ui/editor/editor";


// interface ScreeningParamsProps{
//     movieId: string
// }

interface IAuditoriumScreeningGrouped {
    auditoriumName?: string,
    auditoriumScreening?: AuditoriumScreening[]
}

const Screening: React.FC<{ id: string }> = ({ id }) => {
    const dispatch = useAppDispatch();
    const navigation = useNavigate();
    const isLogin = useAppSelector(state => state.user.isLogin);
    // const screening_state = useAppSelector(state => state.screening.screenings)
    const [screenings, setScreening] = useState([] as ScreeningModel[]);
    const { movieId } = useParams<string>();
    const sessionId = localStorage.getItem("sessionId") || "not_found"

    const [auditoriumScreening, setAuditoriumScreening] = useState<any>();
    const [bookingDate, setBookingDate] = useState<Date>(new Date());
    const [minDateFrom, setMinDateFrom] = useState<Date>();
    const [maxDateTo, setMaxDateTo] = useState<Date>();

    const GetScreeningByMovie = useCallback(async () => {
        const result = await GetScreeningByMovieId(id);

        setScreening([...result.data])
        const minDateFrom = result.data.reduce((min, screening) => {
            if (screening.dateFrom < min) {
              return screening.dateFrom;
            }
            return min;
          }, result.data[0].dateFrom);

          const maxDateTo =  result.data.reduce((max, screening) => {
            if (screening.dateTo > max) {
              return screening.dateTo;
            }
            return max;
          }, result.data[0].dateTo);

          setMinDateFrom(minDateFrom);
          setMaxDateTo(maxDateTo)

        // const groupedData = result.data.reduce((acc: ScreeningModel[], item) => {
        //     // Kiểm tra xem nhóm đã tồn tại trong mảng kết quả chưa
        //     const group = acc.find(group => group. === item.category);

        //     if (group) {
        //         // Nếu nhóm đã tồn tại, thêm mục vào nhóm đó
        //         group.items.push(item);
        //     } else {
        //         // Nếu nhóm chưa tồn tại, tạo một nhóm mới và thêm vào mảng kết quả
        //         acc.push({ category: item.category, items: [item] });
        //     }

        //     return acc;
        // }, []);

        console.log(result.data, "lịch chiếu")
    }, [id])

    useEffect(() => {
        // dispatch(GetScreeningByMovieIdAsync(id));
        // console.log(screening_state, "screening state redux")
        // if(!screening_state || screening_state.length === 0){
        GetScreeningByMovie();
        // }
        // console.log(screenings, "screening state")
    }, [GetScreeningByMovie])



    const handleDateChange = (e: NativeEventInfo<dxDateBox, Event> & ValueChangedInfo) => {
        setBookingDate(e.value)
        GetScreeningByMovieId(id, bookingDate).then(response => {
            setScreening([...response.data])

        });
    }

    useEffect(() => {
        dispatch(clearAllTickets())
    })



    return (
        <>
            <Header as='h3' dividing className="text-white">
                Lịch chiếu
            </Header>
            <Grid>
                <Grid.Row>
                    <Grid.Column computer={6}>
                        <DateBox applyValueMode="useButtons"
                            value={bookingDate}
                            type="date"
                            min={minDateFrom}
                            max={maxDateTo}
                            displayFormat={"dd/MM/yyyy"}
                            inputAttr={{ 'aria-label': 'Date Time', "name": "end_time" }}
                            onValueChanged={handleDateChange} />
                    </Grid.Column>
                </Grid.Row>
            </Grid>
            <Item.Group>
                {screenings && screenings.map((screening, idx) => {

                    const groupedData: IAuditoriumScreeningGrouped[] | undefined = screening.auditoriumScreenings?.reduce((acc: IAuditoriumScreeningGrouped[], item: AuditoriumScreening) => {
                        const group = acc.find((group: IAuditoriumScreeningGrouped) => group.auditoriumName === item.auditoriumName);

                        if (group) {
                            group.auditoriumScreening?.push(item);
                        } else {
                            acc.push({ auditoriumName: item.auditoriumName, auditoriumScreening: [item] });
                        }

                        return acc;
                    }, []);

                    console.log(groupedData, "group")
                    return <Item key={idx} className="bg-gray-700 p-5 rounded">


                        <Item.Content>
                            <Item.Header className="text-white">{screening.cinemaName}</Item.Header>
                            <Item.Meta className="text-gray-200 text-base ">
                                <span className='price'>{screening.screeningTypeName}</span>
                            </Item.Meta>
                            <Item.Description className="pt-3">
                                <Grid className="">
                                    {
                                        groupedData?.map((auditoriumScreening, idx) => {
                                            return <Grid.Row className="py-1"  >
                                                <Grid.Column width={12} className="">
                                                    <Header as='h3' className="text-white py-3">
                                                        {auditoriumScreening.auditoriumName}
                                                    </Header>
                                                </Grid.Column>
                                                <Grid.Column width={12}>
                                                    {auditoriumScreening.auditoriumScreening?.map((auditoriumScreening, idex) => (
                                                        <Button
                                                            key={idex}
                                                            // as={Link}
                                                            onClick={(e) => {
                                                                console.log(screening, "isLogin", isLogin, "screening in click audit")
                                                                if (isLogin === null || isLogin === false) {
                                                                    e.preventDefault();
                                                                    dispatch(checkLogin({ isLogin: false }))
                                                                    return false;
                                                                }
                                                                else {

                                                                    if(maxDateTo && bookingDate > moment(maxDateTo).toDate()){
                                                                        Notify({
                                                                            message: STATUS_MESSAGE["SHOW_DATE_OUT_OF_RANGE"],
                                                                            // height: 45,
                                                                            width: 350,
                                                                            minWidth: 350,
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
                                                                    }
                                                                    else{
                                                                        dispatch(bookScreeningId({
                                                                            showDate: bookingDate,
                                                                            screening: {
                                                                                id: auditoriumScreening.movieSchedule.id,
                                                                                cinemaId: screening.cinemaId,
                                                                                cinemaName: screening.cinemaName,
                                                                                auditoriumName: screening.auditoriumName,
                                                                                auditoriumId: screening.auditoriumId,
                                                                                screeningTypeName: screening.screeningTypeName,
                                                                                movieSchedule: [auditoriumScreening.movieSchedule]
                                                                            } as ScreeningModel
                                                                        }))
                                                                        navigation(`/booking/${screening.cinemaId}/movie/${movieId}/sessionId/${sessionId!}`);
                                                                    }
                                                                }

                                                            }}
                                                            >{moment.utc(auditoriumScreening.movieSchedule.showTime).local().format("HH:mm")}</Button>
                                                    ))}
                                                </Grid.Column>
                                            </Grid.Row>
                                        })
                                    }

                                </Grid>

                            </Item.Description>
                        </Item.Content>
                    </Item>
                })}


            </Item.Group>
        </>
    )
}

export default Screening;