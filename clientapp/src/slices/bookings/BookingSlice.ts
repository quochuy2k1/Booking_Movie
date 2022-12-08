import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { Combo } from "../combos/comboSlice";
import { ScreeningModel } from "../screenings/ScreeningSlice";
import { SeatState } from "../seats/SeatSlice";
import { Ticket } from "../tickets/ticketSlice";


export interface BookingState {
    userId: string,
    screening: ScreeningModel | undefined,
    paymentMethod: string,
    coupon: string,
    combos: Combo[],
    tickets: Ticket[],
    seatRevered: SeatState[]

}


const initialState: BookingState = {
    userId: "",
    screening: undefined,
    paymentMethod: "",
    coupon: "",
    combos: [] as Combo[],
    tickets: [] as Ticket[],
    seatRevered: [] as SeatState[]

}




export const BookingSlice = createSlice({
    name: "booking",
    initialState,
    reducers: {
        bookScreening: (state, action) =>{
            state.screening = action.payload as ScreeningModel
        },
        bookSeat: (state, action) =>{
            console.log(action.payload, "book seat")
            state.seatRevered.push(action.payload as SeatState)
        },
        cancelBookSeat: (state, action) =>{
            const newStateSeatReserved = [...state.seatRevered];
            const index = newStateSeatReserved.findIndex((seat, idx) => seat.id === action.payload.id);
            newStateSeatReserved.splice(index, 1);
            state.seatRevered = newStateSeatReserved;
        }
    },
    extraReducers: builder => {

    }
});

export const { bookScreening, bookSeat, cancelBookSeat } = BookingSlice.actions;

export default BookingSlice.reducer;