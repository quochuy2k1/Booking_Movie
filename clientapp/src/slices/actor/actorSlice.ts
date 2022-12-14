import { createAsyncThunk, createSlice, current } from "@reduxjs/toolkit";
import { ActorPagingRequest, GetAllActor, GetAllActorPaging } from "../../services/actor.service";


export interface Actor {
    id: string,
    name: string,
    viewCount: number,
    nationalityId: string,
    height: number,
    dateOfBirth: string,
    image: string,
    // status: string
}

export interface ActorState {
    actors: Actor[],
    total?: number,
    status: string,
    error: any
}


const initialState: ActorState = {
    actors: [] as Actor[],
    total: 0,
    status: "",
    error: null
}

export const GetAllActorPagingAsync = createAsyncThunk(
    "actor/getallpaging",
    async (request: ActorPagingRequest, { rejectWithValue }) => {
        // const {PageIndex, PageSize, Nationality, Sortby} = request;
        try {
            const response = await GetAllActorPaging(request);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
)

export const GetAllActorAsync = createAsyncThunk(
    "actor/getall",
    async (request, { rejectWithValue }) => {
        // const {PageIndex, PageSize, Nationality, Sortby} = request;
        try {
            const response = await GetAllActor();
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
)


export const actorSlice = createSlice({
    name: 'actor',
    initialState,
    reducers: {},
    extraReducers: (builder) => {
        builder.addCase(GetAllActorPagingAsync.pending, (state, action) => {
            state.status = "loading"
        })
            .addCase(GetAllActorPagingAsync.fulfilled, (state, action) => {
                const { result, total } = action.payload;
                console.log(action.payload, "actor slice")
                Object.assign(state, { actors: [...result], status: "idle", total: total })
                // console.log( current(state.result), "payload actor lít")
            })
            .addCase(GetAllActorPagingAsync.rejected, (state, action) => {
                state.status = "failed"
            })


        builder.addCase(GetAllActorAsync.pending, (state, action) => {
            state.status = "loading"
        })
            .addCase(GetAllActorAsync.fulfilled, (state, action) => {
                Object.assign(state, { result: [...action.payload], status: "idle"})
            })
            .addCase(GetAllActorAsync.rejected, (state, action) => {
                state.status = "failed"
            })
    }

})

export default actorSlice.reducer;