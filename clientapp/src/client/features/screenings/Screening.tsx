import moment from "moment";
import React, { useCallback, useEffect, useState } from "react";
import { Link, useParams } from "react-router-dom";
import { Button, Header, Item } from "semantic-ui-react";
import { useAppDispatch } from "../../../app/hooks";
import { GetScreeningByMovieId } from "../../../services/movie.service";
import { bookScreening } from "../../../slices/bookings/BookingSlice";
import { ScreeningModel } from "../../../slices/screenings/ScreeningSlice";


// interface ScreeningParamsProps{
//     movieId: string
// }

const Screening: React.FC<{id: string}> = ({ id}) => {
    const dispatch = useAppDispatch();
    // const screening_state = useAppSelector(state => state.screening.screenings)
    const [screenings, setScreening] = useState([] as ScreeningModel[]);
    const { movieId } = useParams<string>();
    const sessionId = localStorage.getItem("sessionId") || "not_found"

    const GetScreeningByMovie = useCallback(async () => {
            const result = await GetScreeningByMovieId(id);
           
            setScreening([...result.data])
            console.log(screenings, "lịch chiếu")
    }, [id])
    
    useEffect(()=>{
        // dispatch(GetScreeningByMovieIdAsync(id));
        // console.log(screening_state, "screening state redux")
        // if(!screening_state || screening_state.length === 0){
            GetScreeningByMovie();
        // }
        // console.log(screenings, "screening state")
    }, [GetScreeningByMovie])
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
                     <Item.Meta className="text-white">
                         <span className='price'>{screening.screeningTypeName}</span>
                     </Item.Meta>
                     <Item.Description className="pt-3">
                     {screening && screening.showTime.map((showTime, idex) => (
                        <Button 
                        key={idex} 
                        as={Link} 
                        onClick={() => dispatch(bookScreening({cinemaId: screening.cinemaId, 
                            cinemaName: screening.cinemaName,
                            auditoriumName: screening.auditoriumName, 
                            screeningTypeName: screening.screeningTypeName,
                            showTime: showTime, status: screening.status}))}
                        to={`/booking/${screening.cinemaId}/movie/${movieId}/sessionId/${sessionId!}`}>{moment(showTime).format("HH:mm")}</Button>
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