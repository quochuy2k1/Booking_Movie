import { createSlice } from "@reduxjs/toolkit";
import { SeatNoState, SeatState } from "./SeatSlice";


export interface BookingSeatNo {

    seatNoId: number,
    seatId: string

}

export interface BookingSeatNoState{
    seatNo: BookingSeatNo[],
    status: string,
    error: any
}

const initialState: BookingSeatNoState = {
    seatNo:  [] as BookingSeatNo[],
    status: "",
    error: null

}


export const SeatReservedSlice = createSlice({
    name: "seatReserved",
    initialState,
    reducers: {
      
        bookSeat: (state, action) =>{
            // console.log(action.payload, "book seat")
            const { seatNoId, id } = action.payload as SeatNoState;
            const bookingSN: BookingSeatNo = {
                seatNoId: seatNoId,
                seatId: id
            }
            state.seatNo.push(bookingSN);
        },
        cancelBookSeat: (state, action) =>{
            const newStateSeatReserved = [...state.seatNo];
            const index = newStateSeatReserved.findIndex((seat, idx) => seat.seatNoId === action.payload.seatNoId);
            newStateSeatReserved.splice(index, 1);
            state.seatNo = newStateSeatReserved;
        }
    },
  
});

export const {  bookSeat, cancelBookSeat } = SeatReservedSlice.actions;

export default SeatReservedSlice.reducer;