import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllCombo } from "../../services/combo.service";
import { GetTicketsAsync } from "../tickets/ticketSlice";

export interface ComboModel {
    id: string,
    name: string,
    description: string,
    price: number,
}

// Làm đúng là tạo interface BookingCombo extends Combo
export interface Combo {
    id: string,
    name: string,
    description: string,
    price: number,
    quantity?: number,
    total?: number,
}

export interface ComboState {
    combos: Combo[],
    status: string
}

const initialState: ComboState = {
    combos: [] as Combo[],
    status:""
}


export const GetCombosAsync = createAsyncThunk(
    "combo/getCombos",
    async (request,{rejectWithValue}) => {
        try {
            const response = await GetAllCombo();
            console.log(response.data, "async ticket")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const ComboSlice = createSlice({
    name: "combo",
    initialState,
    reducers:{
        incrementQuantityCombo: (state, action) =>{
             const newCombo = [...state.combos.map((combo => {
                if(combo.id === action.payload.id){
                    combo.quantity! ++;
                    combo.total = combo.quantity! * combo.price
                }
                return combo;
             }))]
             state.combos = newCombo;
        },
        decrementQuantityCombo: (state, action) =>{
            const newCombo = [...state.combos.map((combo => {
               if(combo.id === action.payload.id){
                   combo.quantity! --;
                   combo.total = combo.quantity! * combo.price
               }
               return combo;
            }))]
            state.combos = newCombo;
       },
       emptyBookCombo: (state) => {
            state.combos = [] as Combo[]
       }
    },
    extraReducers: (builder) => {
        builder.addCase(GetCombosAsync.pending, (state, action)=>{
            state.status = "loading";
        })
        .addCase(GetCombosAsync.fulfilled, (state, action) => {
            // console.log(action.payload, "payload combo")
            const combos = action.payload.map(combo => ({...combo, quantity: 0, total: 0}))
            const status = "idle";
            Object.assign(state, {combos, status})
        })
        .addCase(GetCombosAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});

export const {incrementQuantityCombo, decrementQuantityCombo, emptyBookCombo} = ComboSlice.actions;
export default ComboSlice.reducer;