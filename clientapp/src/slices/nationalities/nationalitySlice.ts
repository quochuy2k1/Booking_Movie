import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllNationalities } from "../../services/nationality.service";




export interface NationalityModel {
    id: string,
    name: string,
    code: string,
    description:string,
    flagActor: boolean,
    flagDirector: boolean,
    flagProducer: boolean,
    flagMovie: boolean
}

export interface NationalityState {
    nationalities: NationalityModel[],
    status: string
}

const initialState: NationalityState = {
    nationalities: [] as NationalityModel[],
    status:""
}


export const GetNationalitiesAsync = createAsyncThunk(
    "nationality/getNationalities",
    async (request,{rejectWithValue}) => {
        try {
            const response = await GetAllNationalities();
            console.log(response.data, "async nationalities")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const NationalitySlice = createSlice({
    name: "nationality",
    initialState,
    reducers:{
        
    },
    extraReducers: (builder) => {
        builder.addCase(GetNationalitiesAsync.pending, (state, action)=>{
            state.status = "loading";
        })
        .addCase(GetNationalitiesAsync.fulfilled, (state, action) => {
            const nationalities = action.payload
            const status = "idle";
            Object.assign(state, {nationalities, status})
        })
        .addCase(GetNationalitiesAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});


export default NationalitySlice.reducer;