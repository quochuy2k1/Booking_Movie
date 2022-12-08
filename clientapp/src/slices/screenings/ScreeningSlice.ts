import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetScreeningByMovieId } from "../../services/movie.service";


export interface ScreeningModel{
    cinemaId: number,
    cinemaName: string,
    auditoriumName: string,
    screeningTypeName: string,
    showTime: string[],
    status: string
}

export interface ScreeningState{
    screenings: ScreeningModel[],
    status: string
}


const initialState: ScreeningState = {
   screenings: [] as ScreeningModel[],
   status: ""

}

export const GetScreeningByMovieIdAsync = createAsyncThunk(
    "screening/GetScreeningByMovieId",
    async(id: string, { rejectWithValue}) => {
        try {
            const response = await GetScreeningByMovieId(id);
            console.log(response.data, "async screening")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const ScreeningSlice = createSlice({
    name: "screening",
    initialState,
    reducers:{
        addScreening: (state, action) =>{
            state.screenings.push(action.payload)
        },
       
    },
    extraReducers: builder => {
        builder.addCase(GetScreeningByMovieIdAsync.pending, (state, action) =>{
            state.status = "loading";
        })
        .addCase(GetScreeningByMovieIdAsync.fulfilled, (state, action) =>{
            Object.assign(state, {status: "idle", screenings: action.payload})
        })
        .addCase(GetScreeningByMovieIdAsync.rejected, (state, action) =>{
            state.status = "failed";
        })
    }
});

export const  { addScreening } = ScreeningSlice.actions;


export default ScreeningSlice.reducer;