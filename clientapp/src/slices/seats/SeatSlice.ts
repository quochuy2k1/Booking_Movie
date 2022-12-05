import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";


export interface SeatState{
    id: string,
    row: string,
    number: number,
    rowIndex: number,
    columnIndex: number,
    seatStyle: number,
    status: boolean,

}


const initialState: SeatState = {
    id: "",
    row: "",
    number: 0,
    rowIndex: 0,
    columnIndex: 0,
    seatStyle: 0,
    status: false,

}




export const SeatSlice = createSlice({
    name: "seat",
    initialState,
    reducers:{},
    extraReducers: builder => {
        
    }
});