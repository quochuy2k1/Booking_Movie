// project imports
import config from '../../admin/config';
import { Interface } from 'readline';

// action - state management
import { createSlice } from '@reduxjs/toolkit';

export interface customization {
    isOpen: boolean[], // for active default menu
    fontFamily: string,
    borderRadius: number,
    opened: true
}

export const initialState: customization = {
    isOpen: [] as boolean[], // for active default menu
    borderRadius: config.borderRadius,
    fontFamily: "Roboto",
    opened: true
};

// ==============================|| CUSTOMIZATION REDUCER ||============================== //

export const CustomizationSlice = createSlice({
    name: "customization",
    initialState,
    reducers: {
        MenuOpen: (state, action) => {
            const id = action.payload.id;
            return {
                ...state,
                isOpen: [id]
            };
        },
        SetMenu: (state, action) => {
            return {
                ...state,
                opened: action.payload.opened
            };
        },
        SetFontFamily: (state, action) => {
            return {
                ...state,
                fontFamily: action.payload.fontFamily
            };
        },
        SetBorderRadius: (state, action) => {
            return {
                ...state,
                borderRadius: action.payload.borderRadius
            };
        }
    }
});

export const { MenuOpen, SetBorderRadius, SetFontFamily, SetMenu } = CustomizationSlice.actions;

export default CustomizationSlice.reducer;
