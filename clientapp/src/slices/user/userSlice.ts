import { object } from 'yup';
import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { SignIn, SignOut } from "../../services/user.service";

export interface UserState {
    appUser: {
        lastName: string,
        firstName: string,
        userName: string,
        roles: string[]
    },
    token: string,
    exp?: string,
    statusResponse?: number,
    statusMessageResponse?: string,
    status: string,
    sessionId: string,
    isLogin: boolean | null,
    error: any,
}

const initialState: UserState =
{
    status: "",
    appUser: {
        firstName: "",
        lastName: "",
        userName: "",
        roles: []
    },
    token: "",
    statusResponse: undefined,
    statusMessageResponse: "",
    exp: undefined,
    sessionId: "",
    isLogin: null,
    error: null
}

export const SignInAsync = createAsyncThunk(
    'user/SignIn',
    async (UserData: { UserName: string, Password: string, Remember: boolean }, { rejectWithValue }) => {
        const { UserName, Password, Remember } = UserData;
        try {
            const response = await SignIn(UserName, Password, Remember);
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
);

export const SignOutAsync = createAsyncThunk(
    'user/SignOut',
    async (UserData, { rejectWithValue }) => {
       
        try {
            const response = await SignOut();
            // The value we return becomes the `fulfilled` action payload
            return response.data;
        }
        catch (err: any) {
            return rejectWithValue(err.response.data)
        }
    }
);

export const userSlice = createSlice({
    name: 'user',
    initialState,
    reducers: {
        checkLogin: (state, action) =>{
            state.isLogin = action.payload.isLogin as boolean | null;
        },
        emptyUserError: (state) => {
            state.error = null;
        }
    },
    extraReducers: (builder) => {
        builder
            .addCase(SignInAsync.pending, (state) => {
                state.status = 'loading';
            })
            .addCase(SignInAsync.fulfilled, (state, action) => {
                const { userName, lastName, firstName, roles } = action.payload.appUser
                Object.assign(state, { status: 'idle', appUser: action.payload.appUser, isLogin: true, statusMessageResponse: action.payload.statusMessageResponse, statusResponse: action.payload.statusResponse } as UserState)
                // console.log(action.payload, "payload")
                localStorage.setItem("token", action.payload.token);
                localStorage.setItem("exp_token", action.payload.exp!);
                localStorage.setItem("sessionId", action.payload.sessionId!);
                localStorage.setItem("user_authenticate", JSON.stringify({ lastName: lastName, firstName: firstName, userName: userName, roles: roles,  isSignIn: true, isLogin: true }))
            })
            .addCase(SignInAsync.rejected, (state, action: any) => {
             
                Object.assign(state, {status: 'failed', error: action.payload as any, statusMessageResponse: action.payload.statusMessageResponse, statusResponse: action.payload.statusResponse})
            });

            builder.addCase(SignOutAsync.pending, (state) => {
                state.status = 'loading';
            })
            .addCase(SignOutAsync.fulfilled, (state, action) => {
                const isLogout = action.payload.isLogout;
                Object.assign(state, { status: 'idle', appUser: null, isLogin: null })
                // console.log(action.payload, "payload")
                localStorage.removeItem("token");
                localStorage.removeItem("exp_token");
                localStorage.removeItem("sessionId");
                localStorage.removeItem("user_authenticate");
            })
            .addCase(SignOutAsync.rejected, (state, action: any) => {
             
                Object.assign(state, {status: 'failed', error: action.payload as any})
            });
    }

});
export const { emptyUserError, checkLogin} = userSlice.actions;

export default userSlice.reducer;