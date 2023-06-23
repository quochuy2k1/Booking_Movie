import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { CreateMovie, DeleteMovie, GetAllMoviePaging, MovieCreateRequest, MovieDeleteRequest, MoviePagingRequest, MovieUpdateRequest, UpdateMovie } from "../../services/movie.service";


export interface MovieModel {
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
    status: boolean,
    isShowing: boolean,
    commingSoon: boolean,

    actors: string,
    categories: string,
    directors: string,
}


export interface MovieState {
    movies: MovieModel[],
    total: number,
    status: string,
    error: any
}

const initialState: MovieState = {
    movies: [] as MovieModel[],
    total: 0,
    status: "",
    error: null

}

export const GetAllMoviePagingAsync = createAsyncThunk(
    "movie/getallpaging",
    async (request: MoviePagingRequest, { rejectWithValue }) => {
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

export const CreateNewMovieAsync = createAsyncThunk(
    "movie/create",
    async (request: MovieCreateRequest, { rejectWithValue }) => {
        try {
            const response = await CreateMovie(request);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
);

export const UpdateMovieAsync = createAsyncThunk(
    "movie/update",
    async (request: MovieUpdateRequest, { rejectWithValue }) => {
        try {
            const response = await UpdateMovie(request);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
);

export const DeleteMovieAsync = createAsyncThunk(
    "movie/delete",
    async (request: MovieDeleteRequest, { rejectWithValue }) => {
        try {
            const response = await DeleteMovie(request);
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
    reducers: {
        addMovie: (state, action) => {

            state.movies = [...state.movies, action.payload];
        },
        emptyMovieError: (state) => {
            state.error = null;
        },
        emptyMovieStatus: (state) => {
            state.status = "";
        },
    },
    extraReducers: (builder) => {
        builder.addCase(GetAllMoviePagingAsync.pending, (state) => {
            state.status = "loading"
        })
            .addCase(GetAllMoviePagingAsync.fulfilled, (state, action) => {
                const { result, total } = action.payload
                Object.assign(state, { movies: [...result], status: "idle", total: total })
                // console.log( current(state.movies), "payload movie lít")
            })
            .addCase(GetAllMoviePagingAsync.rejected, (state, action) => {
                Object.assign(state, { status: "failed", error: action.payload })
            });

        builder.addCase(CreateNewMovieAsync.pending, (state, action) => {
            state.status = "loading"
        })
        .addCase(CreateNewMovieAsync.fulfilled, (state, action) => {
            state.status = "added"
            state.movies.push(action.payload)
        });

        builder.addCase(UpdateMovieAsync.pending, (state, action) => {
            state.status = "loading"
        })
        .addCase(UpdateMovieAsync.fulfilled, (state, action) => {
            const {id} = action.payload;
            state.status = "updated"
            const existsMovie = [...state.movies].findIndex(movie => movie.id === id);
            console.log(existsMovie, "existsMovie")
            if(existsMovie !== -1){
                state.movies[existsMovie] = action.payload
            }
        })
        .addCase(UpdateMovieAsync.rejected, (state, action) => {
            Object.assign(state, { status: "failed", error: action.payload })
        });


        builder.addCase(DeleteMovieAsync.pending, (state) => {
            state.status = "loading"
        })
            .addCase(DeleteMovieAsync.fulfilled, (state, action) => {
                const deletedMovieId = action.payload;
                const newState = [...state.movies].filter((movie) => deletedMovieId.indexOf(movie.id) === -1);
                Object.assign(state, { movies: newState, status: "idle" });
            })
            .addCase(DeleteMovieAsync.rejected, (state, action) => {
                Object.assign(state, { status: "failed", error: action.payload })
            });


    }
});

export const { addMovie, emptyMovieError, emptyMovieStatus } = MovieSlice.actions;

export default MovieSlice.reducer;