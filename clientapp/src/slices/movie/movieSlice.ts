import { createAsyncThunk, createSlice, current } from "@reduxjs/toolkit";
import { GetAllMoviePaging, MoviePagingRequest } from "../../services/movie.service";


export interface MovieModel{
    id: number,
    imagePreview: string,
    imageBackground: string,
    videoTrailer: string,
    name: string,
    duration: number,
    releaseDate: string,
    content: string,
    nationality: string,
    producer: string,
    actors: string,
    categories: string,
    directors: string,
}

export interface MovieState{
    movies: MovieModel[],
    total: number,
    status: string
}

const initialState: MovieState = {
    movies: [] as MovieModel[],
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
    reducers:{
        addMovie: (state, action) => {
            
            state.movies = [...state.movies, action.payload];
        }
    },
    extraReducers: (builder) => {
        builder.addCase(GetAllMoviePagingAsync.pending, (state, action) =>{
            state.status = "loading"
        })
        .addCase(GetAllMoviePagingAsync.fulfilled, (state, action) =>{
            const { result, total } = action.payload
            Object.assign(state, {movies: [...result], status: "idle", total: total })
            // console.log( current(state.movies), "payload movie lít")
        })
        .addCase(GetAllMoviePagingAsync.rejected, (state, action) =>{
            state.status = "failed"
        })
    }
});

export const { addMovie } = MovieSlice.actions;

export default MovieSlice.reducer;