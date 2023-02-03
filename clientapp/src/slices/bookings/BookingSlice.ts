import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllBookingPaging, PaymentStatusUpdateRequest, UpdatePaymentStatus } from "../../services/booking.service";
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
    status: boolean
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

export const UpdatePaymentStatusAsync = createAsyncThunk(
    "booking/update-payment-status",
    async (request: PaymentStatusUpdateRequest, { rejectWithValue }) => {
        // const {PageIndex, PageSize, Nationality, Sortby} = request;
        try {
            const response = await UpdatePaymentStatus(request);
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

            builder.addCase(UpdatePaymentStatusAsync.pending, (state, action) => {
                state.status = "loading"
            })
                .addCase(UpdatePaymentStatusAsync.fulfilled, (state, action) => {
                    // const { result, total } = action.payload;
                    console.log(action.payload, "booking slice")
                    const {id} = action.payload;
                    state.status = "updated"
                    const existsBooking = [...state.bookings].findIndex(booking => booking.id === id);
                    console.log(existsBooking, "existsBooking")
                    if(existsBooking !== -1){
                        state.bookings[existsBooking] = action.payload
                    }
                    // Object.assign(state, { bookings: [...action.payload], status: "idle", total: total })
                    // Object.assign(state, { bookings: [...action.payload], status: "idle", })
                    // console.log( current(state.result), "payload booking lít")
                })
                .addCase(UpdatePaymentStatusAsync.rejected, (state, action) => {
                    state.status = "failed"
                })
    }
});

export const { bookScreening, } = BookingSlice.actions;

export default BookingSlice.reducer;