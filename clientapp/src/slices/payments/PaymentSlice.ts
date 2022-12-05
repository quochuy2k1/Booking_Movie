import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllPayment } from "../../services/payment.service";


export interface PaymentModel{
    id: string,
    name: string,
    alias: string,
    cost: number,
    cost_additional: number,
    status: boolean,

}

export interface PaymentState{
    payments: PaymentModel[],
    status: string,

}


const initialState: PaymentState = {
    payments: [] as PaymentModel[],
    status: "",
}

export const GetAllPaymentAsync = createAsyncThunk(
    "payment/getall",
    async (request, {rejectWithValue}) => {
        try {
            const response = await GetAllPayment();
            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
);


export const PaymentSlice = createSlice({
    name: "payment",
    initialState,
    reducers:{},
    extraReducers: builder => {
        builder.addCase(GetAllPaymentAsync.pending, (state, action) => {
            state.status = "loading"
        })
        .addCase(GetAllPaymentAsync.fulfilled, (state, action) => {
            const status = "idle";
            const payments: PaymentModel[] = action.payload;
            Object.assign(state, {status, payments})
        })
        .addCase(GetAllPaymentAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});

export default PaymentSlice.reducer;