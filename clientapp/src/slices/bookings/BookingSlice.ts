import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllBookingPaging } from "../../services/booking.service";
import { Combo } from "../combos/comboSlice";
import { ScreeningModel } from "../screenings/ScreeningSlice";
import { SeatState } from "../seats/SeatSlice";
import { Ticket } from "../tickets/ticketSlice";


export interface BookingModel {
    id: number,
    userFullName: string,
    showTime: string,
    createdDate: string,
    total: number,
    paymentMethod: string,
    couponId: string,
    combos: Combo[],
    tickets: Ticket[],
    seatRevered: SeatState[]
    flagScanner: boolean,
}

export interface BookingState{
    bookings: BookingModel[],
    status: string,
    total?: number,
    error: any
}


const initialState: BookingState = {
    bookings: [] as BookingModel[],
    status: "",
    total: 0,
    error: null

}

export const GetAllBookingPagingAsync = createAsyncThunk(
    "booking/getallpaging",
    async (request, { rejectWithValue }) => {
        // const {PageIndex, PageSize, Nationality, Sortby} = request;
        try {
            const response = await GetAllBookingPaging();
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
)


export const BookingSlice = createSlice({
    name: "booking",
    initialState,
    reducers: {
        bookScreening: (state, action) =>{
            // state.screening = action.payload as ScreeningModel
        },
        bookSeat: (state, action) =>{
            // console.log(action.payload, "book seat")
            // state.seatRevered.push(action.payload as SeatState)
        },
        cancelBookSeat: (state, action) =>{
            // const newStateSeatReserved = [...state.seatRevered];
            // const index = newStateSeatReserved.findIndex((seat, idx) => seat.id === action.payload.id);
            // newStateSeatReserved.splice(index, 1);
            // state.seatRevered = newStateSeatReserved;
        }
    },
    extraReducers: builder => {
        builder.addCase(GetAllBookingPagingAsync.pending, (state, action) => {
            state.status = "loading"
        })
            .addCase(GetAllBookingPagingAsync.fulfilled, (state, action) => {
                // const { result, total } = action.payload;
                console.log(action.payload, "booking slice")
                // Object.assign(state, { bookings: [...action.payload], status: "idle", total: total })
                Object.assign(state, { bookings: [...action.payload], status: "idle", })
                // console.log( current(state.result), "payload booking lít")
            })
            .addCase(GetAllBookingPagingAsync.rejected, (state, action) => {
                state.status = "failed"
            })
    }
});

export const { bookScreening, bookSeat, cancelBookSeat } = BookingSlice.actions;

export default BookingSlice.reducer;