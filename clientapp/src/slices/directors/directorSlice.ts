import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllDirector } from "../../services/director.service";




export interface DirectorModel {
    id: string,
    name: string,
    viewCount: number,
    nationalityId: string,
    height: number,
    dateOfBirth: string,
    image: string
}

export interface DirectorState {
    directors: DirectorModel[],
    status: string
}

const initialState: DirectorState = {
    directors: [] as DirectorModel[],
    status:""
}


export const GetDirectorAsync = createAsyncThunk(
    "director/getDirector",
    async (request,{rejectWithValue}) => {
        try {
            const response = await GetAllDirector();
            console.log(response.data, "async directors")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const DirectorSlice = createSlice({
    name: "director",
    initialState,
    reducers:{
        
    },
    extraReducers: (builder) => {
        builder.addCase(GetDirectorAsync.pending, (state, action)=>{
            state.status = "loading";
        })
        .addCase(GetDirectorAsync.fulfilled, (state, action) => {
            const directors = action.payload
            const status = "idle";
            Object.assign(state, {directors, status})
        })
        .addCase(GetDirectorAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});


export default DirectorSlice.reducer;