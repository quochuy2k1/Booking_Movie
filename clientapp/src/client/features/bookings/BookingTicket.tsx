import React from "react";
import ComboList from "../combos/comboList";
import TicketList from "../tickets/TicketList";

const BookingTicket: React.FC<{}> = () =>{
    return (
        <>
            <div>
                <TicketList></TicketList>
                <ComboList></ComboList>
            </div>
        </>
    )
}

export default BookingTicket;