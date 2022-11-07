import moment from "moment";
import React, { useCallback, useEffect, useState } from "react";
import { Button, Header, Item } from "semantic-ui-react";
import { GetScreeningByMovieId } from "../../services/movie.service";

export interface ScreeningState{
    cinameName: string,
    screeningTypeName: string,
    showTime: string[],
}

const Screening: React.FC<{id: number}> = ({ id}) => {

    const [screenings, setScreening] = useState([] as ScreeningState[]);

    const GetScreeningByMovie = useCallback(async () => {
            const result = await GetScreeningByMovieId(id)
            setScreening([...result.data])
            console.log(screenings, "lịch chiếu")
    }, [id])
    useEffect(()=>{
        GetScreeningByMovie();
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
                     <Item.Header className="text-white">{screening.cinameName}</Item.Header>
                     <Item.Meta className="text-white">
                         <span className='price'>{screening.screeningTypeName}</span>
                     </Item.Meta>
                     <Item.Description className="pt-3">
                     {screening && screening.showTime.map(showTime => (
                        <Button>{moment(showTime).format("HH:mm")}</Button>
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