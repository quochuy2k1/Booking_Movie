import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllMoviePaging, MoviePagingRequest } from "../../services/movie.service";


export interface Movie{
    id: number,
    imagePreview: string,
    imageBackground: string,
    videoTrailer: string,
    name: string,
    duration: number
}

export interface MovieState{
    movies: Movie[],
    total: number,
    status: string
}

const initialState: MovieState = {
    movies: [] as Movie[],
    total :0,
    status: ""

}

export const GetAllMoviePagingAsync = createAsyncThunk(
    "movie/getallpaging",
    async (request: MoviePagingRequest, {rejectWithValue}) => {
        try {
            const response = await GetAllMoviePaging(request);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
);

export const MovieSlice = createSlice({
    name: "movie",
    initialState,
    reducers:{},
    extraReducers: (builder) => {
        builder.addCase(GetAllMoviePagingAsync.pending, (state, action) =>{
            state.status = "loading"
        })
        .addCase(GetAllMoviePagingAsync.fulfilled, (state, action) =>{
            const { result, total } = action.payload
            state.status = "idle"
            state.movies = [...result];
            state.total = total;
            console.log( state.movies, "payload movie lít")
        })
        .addCase(GetAllMoviePagingAsync.rejected, (state, action) =>{
            state.status = "failed"
        })
    }
});

export default MovieSlice.reducer;