import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";


export interface SeatState {
    id: string,
    row: string,
    number: number,


}

export interface SeatNoState extends SeatState {

    seatNoId: number,
    rowIndex: number,
    columnIndex: number,
    seatStyle: number,
    status: boolean,

}



const initialState: SeatState = {
    id: "",
    row: "",
    number: 0,

}




export const SeatSlice = createSlice({
    name: "seat",
    initialState,
    reducers: {},
    extraReducers: builder => {

    }
});