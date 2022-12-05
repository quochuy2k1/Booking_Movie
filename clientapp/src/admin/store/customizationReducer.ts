// project imports
import config from '../config';
import { Interface } from 'readline';

// action - state management
import * as actionTypes from './actions';

export interface customization{
    isOpen: boolean[], // for active default menu
    fontFamily: string,
    borderRadius: number,
    opened: true
}

export const initialState: customization = {
    isOpen: []  as boolean[], // for active default menu
    borderRadius: config.borderRadius,
    fontFamily: "Roboto",
    opened: true
};

// ==============================|| CUSTOMIZATION REDUCER ||============================== //

const customizationReducer = (state = initialState, action: any) => {
    let id;
    switch (action.type) {
        case actionTypes.MENU_OPEN:
            id = action.id;
            return {
                ...state,
                isOpen: [id]
            };
        case actionTypes.SET_MENU:
            return {
                ...state,
                opened: action.opened
            };
        case actionTypes.SET_FONT_FAMILY:
            return {
                ...state,
                fontFamily: action.fontFamily
            };
        case actionTypes.SET_BORDER_RADIUS:
            return {
                ...state,
                borderRadius: action.borderRadius
            };
        default:
            return state;
    }
};

export default customizationReducer;
