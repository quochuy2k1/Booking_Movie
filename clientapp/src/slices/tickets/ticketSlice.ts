import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { StringLiteralType } from "typescript";
import { GetAllTicket, GetTicketByMovieId, GetTicketByScreeningId, GetTicketRequest } from "../../services/ticket.service";


// Làm đúng là tạo interface BookingTicket extends Ticket
export interface Ticket {
    id: string,
    name: string,
    ticketTypeName: string,
    price: number,
    quantity?: number,
    total?: number
}

export interface TicketState {
    tickets: Ticket[],
    chooseTotal: number,
    status: string
}

const initialState: TicketState = {
    tickets: [] as Ticket[],
    chooseTotal: 0,
    status: ""
}

export const GetTicketsAsync = createAsyncThunk(
    "ticket/getTickets",
    async (request: GetTicketRequest, { rejectWithValue }) => {
        try {
            // const response = await GetAllTicket();
            const response = await GetTicketByMovieId(request);
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
    reducers: {
        incrementQuantityTicket: (state, action) => {
            const newTicket = [...state.tickets.map((ticket => {
                if (ticket.id === action.payload.id) {
                    ticket.quantity! ++;
                    ticket.total = ticket.quantity! * ticket.price
                    state.chooseTotal++;

                }
                return ticket;
            }))]
            Object.assign(state, { tickets: newTicket })
        },
        decrementQuantityTicket: (state, action) => {
            const newTicket = [...state.tickets.map((ticket => {
                if (ticket.id === action.payload.id) {
                    ticket.quantity! --;
                    ticket.total = ticket.quantity! * ticket.price
                    state.chooseTotal--;

                }
                return ticket;
            }))]

            Object.assign(state, { tickets: newTicket })
        },
        resetQuantityBookTicket: (state) => {
            const newState = [...state.tickets].map(ticket => { ticket.quantity = 0; ticket.total = 0; return ticket })
            Object.assign({ chooseTotal: 0, tickets: newState })
        },
        clearAllTickets : (state) => {
            state.tickets = []
            state.chooseTotal = 0
        }
    },
    extraReducers: (builder) => {
        builder.addCase(GetTicketsAsync.pending, (state, action) => {
            state.status = "loading";
        })
            .addCase(GetTicketsAsync.fulfilled, (state, action) => {
                // console.log(action.payload, "payload ticket")
                const tickets = [...action.payload.map(ticket => ({ ...ticket, quantity: 0, total: 0 }))]
                Object.assign(state, { tickets: tickets, status: "idle" })
            })
            .addCase(GetTicketsAsync.rejected, (state, action) => {
                state.status = "failed"
            })
    }
});


export const { incrementQuantityTicket, decrementQuantityTicket, resetQuantityBookTicket, clearAllTickets } = TicketSlice.actions

export default TicketSlice.reducer;