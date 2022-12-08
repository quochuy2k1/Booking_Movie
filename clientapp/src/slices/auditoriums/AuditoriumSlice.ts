import { areArraysEqual } from '@mui/base';
import { createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { StatisticLabel } from 'semantic-ui-react';
import { GetSeatByAuditorium } from '../../services/auditorium.service';
import { SeatState } from '../seats/SeatSlice';

export interface AuditoriumModel{
    physicalName: string,
    seats: SeatState[],
    status: string
}

export interface AuditoriumState{
    areas: AuditoriumModel[],
    length: number,
    classSelect: SeatState[],
    status?: string
}

const initialState: AuditoriumState = {
    areas: [] as AuditoriumModel[],
    classSelect: [] as SeatState[],
    length: 0,
    status: "",

}

export const GetSeatByAuditoriumAsync = createAsyncThunk(
    "auditorium/GetSeatByAuditorium",
    async (id: string, {rejectWithValue}) =>{
        try {
            const response = await GetSeatByAuditorium(id);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const AuditoriumSlice = createSlice({
    name: "auditorium",
    initialState,
    reducers:{
        loadClassSelect: (state, action) =>{
            state.classSelect = action.payload as SeatState[];
        },
        addClassSelect: (state, action) =>{
            const newState = [...state.classSelect, action.payload as SeatState];
            state.classSelect = newState;
        },
        removeClassSelect: (state, action) =>{
            const newState = [...state.classSelect];
            const index = newState.findIndex(select => select.id === action.payload.id)
            newState.splice(index, 1)
            state.classSelect = newState;
        },
        removeClassSelectByIndex: (state, action) =>{
            const newState = [...state.classSelect];
            const index = action.payload.index;
            newState.splice(index, 1)
            state.classSelect = newState;
        },
        chooseSeats: (state, action) =>{
            const { area, id } = action.payload as {area: number, id: string};
            const newState = [...state.areas[area].seats.map(seat => {
                if(seat.id === id)  seat.status = true;
                return seat;
            })]
            state.areas[area].seats = newState;
        }
    },
    extraReducers: builder => {
        builder.addCase(GetSeatByAuditoriumAsync.pending, (state, action) =>{
            state.status = "loading"
        })
        .addCase(GetSeatByAuditoriumAsync.fulfilled, (state, action) =>{
            const areas = action.payload as AuditoriumModel[];
            const length = Math.max(...action.payload.map((val) => val.seats.length));
            const status = "idle";
            Object.assign(state, {areas, length, status})
        })
        .addCase(GetSeatByAuditoriumAsync.rejected, (state, action) =>{
            state.status = "failed";
        })
    }
});

export const { chooseSeats, loadClassSelect, addClassSelect, removeClassSelect, removeClassSelectByIndex } = AuditoriumSlice.actions;

export default AuditoriumSlice.reducer;