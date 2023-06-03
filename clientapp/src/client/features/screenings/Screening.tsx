import moment from "moment";
import React, { useCallback, useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import { Button, Header, Item } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { GetScreeningByMovieId } from "../../../services/movie.service";
import { bookScreening } from "../../../slices/bookings/BookingSlice";
import { ScreeningModel, addScreening } from "../../../slices/screenings/ScreeningSlice";
import { bookScreeningId } from "../../../slices/bookings/BookingSliceClient";
import { checkLogin } from "../../../slices/user/userSlice";
import { clearAllTickets } from "../../../slices/tickets/ticketSlice";


// interface ScreeningParamsProps{
//     movieId: string
// }

const Screening: React.FC<{ id: string }> = ({ id }) => {
    const dispatch = useAppDispatch();
    const isLogin = useAppSelector(state => state.user.isLogin);
    // const screening_state = useAppSelector(state => state.screening.screenings)
    const [screenings, setScreening] = useState([] as ScreeningModel[]);
    const { movieId } = useParams<string>();
    const sessionId = localStorage.getItem("sessionId") || "not_found"

    const GetScreeningByMovie = useCallback(async () => {
        const result = await GetScreeningByMovieId(id);

        setScreening([...result.data])
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

    useEffect(() => {
        dispatch(clearAllTickets())
    })


    
    return (
        <>
            <Header as='h3' dividing className="text-white">
                Lịch chiếu
            </Header>
            <Item.Group>
                {screenings && screenings.map((screening, idx) => (
                    <Item key={idx} className="bg-gray-700 p-5 rounded">


                        <Item.Content>
                            <Item.Header className="text-white">{screening.cinemaName}</Item.Header>
                            <Item.Meta className="text-gray-200 text-base ">
                                <span className='price'>{screening.screeningTypeName}</span>
                            </Item.Meta>
                            <Item.Description className="pt-3">
                                {screening && screening.movieSchedule?.map((showTime, idex) => (
                                    <Button
                                        key={idex}
                                        as={Link}
                                        onClick={(e) => {
                                            console.log(screening, "isLogin", isLogin, "screening in click audit")
                                            if (isLogin === null || isLogin === false) {
                                                e.preventDefault();
                                                dispatch(checkLogin({isLogin: false}))
                                                return false;
                                            }
                                            else {
                                                

                                                dispatch(bookScreeningId({
                                                    id: screening.id,
                                                    cinemaId: screening.cinemaId,
                                                    cinemaName: screening.cinemaName,
                                                    auditoriumName: screening.auditoriumName,
                                                    screeningTypeName: screening.screeningTypeName,
                                                    movieSchedule: [showTime]
                                                } as ScreeningModel))
                                            }

                                        }}
                                        to={`/booking/${screening.cinemaId}/movie/${movieId}/sessionId/${sessionId!}`}>{moment(showTime.showTime).format("HH:mm")}</Button>
                                ))}
                            </Item.Description>
                        </Item.Content>
                    </Item>
                ))}


            </Item.Group>
        </>
    )
}

export default Screening;