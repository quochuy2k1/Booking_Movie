import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllProducer } from "../../services/producer.service";




export interface ProducerModel {
    id: string,
    name: string,
    nationalityId: string,
    image: string
}

export interface ProducerState {
    producers: ProducerModel[],
    status: string
}

const initialState: ProducerState = {
    producers: [] as ProducerModel[],
    status:""
}


export const GetProducerAsync = createAsyncThunk(
    "producer/getProducer",
    async (request,{rejectWithValue}) => {
        try {
            const response = await GetAllProducer();
            console.log(response.data, "async producers")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const ProducerSlice = createSlice({
    name: "producer",
    initialState,
    reducers:{
        
    },
    extraReducers: (builder) => {
        builder.addCase(GetProducerAsync.pending, (state, action)=>{
            state.status = "loading";
        })
        .addCase(GetProducerAsync.fulfilled, (state, action) => {
            const producers = action.payload
            const status = "idle";
            Object.assign(state, {producers, status})
        })
        .addCase(GetProducerAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});


export default ProducerSlice.reducer;