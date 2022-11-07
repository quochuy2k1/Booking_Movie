import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { StringLiteralType } from "typescript";
import { GetAllTicket } from "../../services/ticket.service";



export interface Ticket {
    id: string,
    name: string,
    price: number,
    quantity?: number,
    total?: number
}

export interface TicketState {
    tickets: Ticket[],
    status: string
}

const initialState: TicketState = {
    tickets: [] as Ticket[],
    status:""
}

export const GetTicketsAsync = createAsyncThunk(
    "ticket/getTickets",
    async (request,{rejectWithValue}) => {
        try {
            const response = await GetAllTicket();
            console.log(response.data, "async ticket")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)

export const TicketSlice = createSlice({
    name: "ticket",
    initialState,
    reducers:{
        incrementQuantityTicket: (state, action) =>{
             const newTicket = [...state.tickets.map((ticket => {
                if(ticket.id === action.payload.id){
                    ticket.quantity! ++;
                    ticket.total = ticket.quantity! * ticket.price

                }
                return ticket;
             }))]
             state.tickets = newTicket;
        },
        decrementQuantityTicket: (state, action) =>{
            const newTicket = [...state.tickets.map((ticket => {
               if(ticket.id === action.payload.id){
                   ticket.quantity! --;
                   ticket.total = ticket.quantity! * ticket.price
               }
               return ticket;
            }))]
            state.tickets = newTicket;
       }
    },
    extraReducers: (builder) => {
        builder.addCase(GetTicketsAsync.pending, (state, action)=>{
            state.status = "loading";
        })
        .addCase(GetTicketsAsync.fulfilled, (state, action) => {
            console.log(action.payload, "payload ticket")
            const tickets = [...action.payload.map(ticket => ({...ticket, quantity: 0, total: 0}))]
            state.tickets = tickets;
            state.status = "idle"
        })
        .addCase(GetTicketsAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});


export const { incrementQuantityTicket, decrementQuantityTicket } = TicketSlice.actions

export default TicketSlice.reducer;