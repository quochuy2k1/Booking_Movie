import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { ActorPagingRequest, GetAllActorPaging} from "../../services/actor.service";


export interface Actor{
    id: string,
    name: string,
    viewCount: number,
    nationality: string,
    height: number,
    dateOfBirth: string,
    image: string,
    status: string
}

export interface ActorState{
    result: Actor[],
    total: number,
    status: string
} 


  const initialState: ActorState = {
    result: [] as Actor[],
    total: 0,
    status: ""
  }

  export const GetAllActorPagingAsync = createAsyncThunk(
    "actor/getallpaging",
    async (request : ActorPagingRequest, { rejectWithValue }) => {
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


  export const actorSlice = createSlice({
    name: 'actor',
    initialState ,
    reducers:{},
    extraReducers: (buider) =>{
        buider.addCase(GetAllActorPagingAsync.pending, (state, action) => {
            state.status = "loading"
        })
        .addCase(GetAllActorPagingAsync.fulfilled, (state, action) => {
            const { result, total } = action.payload
            state.status = "idle"
            state.result = [...result];
            state.total = total;
            console.log( state.result, "payload actor lít")
        })
        .addCase(GetAllActorPagingAsync.rejected, (state, action) =>{
            state.status = "failed"
        })
    }

  })

  export default actorSlice.reducer;