import React, {  useEffect,  } from "react";
import { Button, Grid, Header, Input, Segment } from "semantic-ui-react";
import { useAppDispatch, useAppSelector } from "../../../app/hooks";
import { decrementQuantityTicket, GetTicketsAsync, incrementQuantityTicket} from "../../../slices/tickets/ticketSlice";
import "./ticket.css"
import moment from "moment";
import { useParams } from "react-router-dom";

const TicketList: React.FC<{movieId?: string}> = (props) => {

    const dispatch = useAppDispatch();
    const { tickets } = useAppSelector(state => state.ticket)
    const { screening } = useAppSelector(state => state.bookingClient.booking)
    const  status  = useAppSelector(state => state.ticket.status)

   
    useEffect(() => {
        if(tickets.length <= 0){
            props.movieId && dispatch(GetTicketsAsync({movieId: props.movieId,  dateTo: moment.utc(screening.movieSchedule![0].showTime).toDate() }));

        }
    }, [dispatch,])
    return (
        <>
            <Segment className="bg-gray-700">
                <Header as="h3" dividing className="text-white uppercase">Chọn vé</Header>
                <Grid className="bg-gray-700" textAlign="left" verticalAlign="middle" container>
                    <Grid.Column computer={4} className="text-white font-extrabold text-xl">
                        Loại vé
                    </Grid.Column>

                    <Grid.Column textAlign="right" computer={3} className="text-white font-extrabold text-xl">
                        Giá
                    </Grid.Column>


                    <Grid.Column textAlign="right" computer={4} className="text-white font-extrabold text-xl">
                        Số lượng

                    </Grid.Column>

                    <Grid.Column computer={5} textAlign="right" className="text-white font-extrabold text-xl">
                        Tổng giá
                    </Grid.Column>

                </Grid>
                {tickets && tickets.map((ticket, idx) => (
                    <Grid key={idx} className="bg-gray-700" textAlign="left" verticalAlign="middle" container>
                        <Grid.Column computer={4} className="text-white">
                            {ticket.ticketTypeName}
                        </Grid.Column>

                        <Grid.Column textAlign="right" computer={3} className="text-white">
                            {ticket.price.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}đ
                        </Grid.Column>


                        <Grid.Column textAlign="right" computer={4}>
                            <div className="flex justify-end">

                                <Button className="m-0" icon='plus' onClick={() => { dispatch(incrementQuantityTicket({id: ticket.id})) }}></Button>
                                <Input className=" w-14 px-1" value={ticket!.quantity}/>
                                <Button icon='minus' onClick={() => { dispatch(decrementQuantityTicket({id: ticket.id})) }} ></Button>
                            </div>

                        </Grid.Column>

                        <Grid.Column textAlign="right" computer={5} className="text-white">
                            {ticket.total?.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1.')}đ
                        </Grid.Column>

                    </Grid>
                ))}
            </Segment>
        </>
    )
}

export default TicketList;