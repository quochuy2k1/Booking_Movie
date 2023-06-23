import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllScreening, GetScreeningByMovieId } from "../../services/movie.service";

export interface AuditoriumScreening{
    auditoriumName: string,
    movieSchedule: MovieSchedule
}
export interface MovieSchedule{
    id: number,
    showTime: string
}

export interface ScreeningModel{
    id: number,
    cinemaId: number,
    cinemaName: string,
    auditoriumName: string,
    auditoriumId: number,
    movieName?: string,
    movieId?: number,
    screeningTypeName: string,
    screeningTypeId: number,
    dateFrom: Date,
    dateTo: Date,
    movieSchedule?: MovieSchedule[]
    showTimeId: string[],
    auditoriumScreenings?: AuditoriumScreening[]
}



export interface ScreeningState{
    screenings: ScreeningModel[],
    status: string,
    total?: number,
    error?: any
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

export const GetAllScreeningAsync = createAsyncThunk(
    "screening/GetAllScreening",
    async(request, { rejectWithValue}) => {
        try {
            const response = await GetAllScreening();
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
            state.screenings.push(action.payload as ScreeningModel)
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

        builder.addCase(GetAllScreeningAsync.pending, (state, action) =>{
            state.status = "loading";
        })
        .addCase(GetAllScreeningAsync.fulfilled, (state, action) =>{
            Object.assign(state, {status: "idle", screenings: action.payload})
        })
        .addCase(GetAllScreeningAsync.rejected, (state, action) =>{
            state.status = "failed";
        })
    }
});

export const  { addScreening } = ScreeningSlice.actions;


export default ScreeningSlice.reducer;