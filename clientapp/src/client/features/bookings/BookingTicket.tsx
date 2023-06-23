import React from "react";
import ComboList from "../combos/comboList";
import TicketList from "../tickets/TicketList";

const BookingTicket: React.FC<{movieId?: string}> = (props) =>{
    return (
        <>
            <div>
                <TicketList movieId={props.movieId}></TicketList>
                <ComboList></ComboList>
            </div>
        </>
    )
}

export default BookingTicket;