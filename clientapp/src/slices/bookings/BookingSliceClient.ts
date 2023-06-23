import { ScreeningModel } from './../screenings/ScreeningSlice';
import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { BookingCreateRequest, CreateBooking } from "../../services/booking.service";


export interface BookingClientModel {
    paymentMethodId: number,
    couponId: number,
    appUserId: string,
    screening: ScreeningModel,
    showDate: Date,
    Total: number
}


export interface BookingClientState {
    booking: BookingClientModel,
    orderUrl?: string,
    status: string,
    total?: number,
    error: any
}

const initialState: BookingClientState = {
    booking: {} as BookingClientModel,
    orderUrl: "",
    status: "",
    total: 0,
    error: null

}

export const CreateBookingAsync = createAsyncThunk(
    "bookingClient/createBooking",
    async (request: BookingCreateRequest, { rejectWithValue }) => {
        // const {PageIndex, PageSize, Nationality, Sortby} = request;
        try {
            const response = await CreateBooking(request);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
)

export const BookingClientSlice = createSlice({
    name: "bookingClient",
    initialState,
    reducers: {
        bookScreeningId: (state, action) => {
            const screening: ScreeningModel = action.payload.screening;
            const showDate: Date = action.payload.showDate;
            console.log(screening, "payload bookScreeningId")

            sessionStorage.setItem("book-cinema", JSON.stringify(screening))
            showDate && sessionStorage.setItem("showTime", showDate.toISOString())
            Object.assign(state, {
                booking: {
                    ...state.booking,
                    screening: screening,
                    showDate: showDate ?? state.booking.showDate
                }
            });
        },
        bookPayment: (state, action) => {
            // console.log(action.payload, "book seat")
            if (action.payload.paymentMethodId) {
                Object.assign(state, {
                    booking:
                    {
                        ...state.booking,
                        paymentMethodId: action.payload.paymentMethodId as number,
                    }
                })
            }

            if (action.payload.couponId) {
                Object.assign(state, {
                    booking:
                    {
                        ...state.booking,
                        couponId: action.payload.couponId as number,
                    }

                })
            }

            if (action.payload.appUserId) {
                Object.assign(state, {
                    booking:
                    {
                        ...state.booking,
                        appUserId: action.payload.appUserId as string,
                    }

                })
            }
        }


    },
    extraReducers: builder => {
        builder.addCase(CreateBookingAsync.pending, (state, action) => {
            state.status = "loading"
        })
            .addCase(CreateBookingAsync.fulfilled, (state, action) => {
                // const { result, total } = action.payload;
                console.log(action.payload, "booking slice")
                // Object.assign(state, { bookings: [...action.payload], status: "idle", total: total })
                Object.assign(state, { orderUrl: action.payload, status: "idle", })
                // console.log( current(state.result), "payload booking lít")
            })
            .addCase(CreateBookingAsync.rejected, (state, action) => {
                state.status = "failed"
            })
    }
});

export const { bookScreeningId, bookPayment } = BookingClientSlice.actions;

export default BookingClientSlice.reducer;