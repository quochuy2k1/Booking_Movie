import { object } from 'yup';
import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { SignIn } from "../../services/user.service";

export interface UserState {
    appUser: {
        lastName: string,
        firstName: string,
        userName: string,
    },
    token: string,
    exp?: string,
    status: string,
    sessionId: string,
    error: any,
}

const initialState: UserState =
{
    status: "",
    appUser: {
        firstName: "",
        lastName: "",
        userName: ""
    },
    token: "",
    exp: undefined,
    sessionId: "",
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

export const userSlice = createSlice({
    name: 'user',
    initialState,
    reducers: {
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
                const { userName, lastName, firstName } = action.payload.appUser
                Object.assign(state, { status: 'idle', appUser: action.payload.appUser })
                // console.log(action.payload, "payload")
                localStorage.setItem("token", action.payload.token);
                localStorage.setItem("exp_token", action.payload.exp!);
                localStorage.setItem("sessionId", action.payload.sessionId!);
                localStorage.setItem("user_authenticate", JSON.stringify({ lastName: lastName, firstName: firstName, userName: userName, isSignIn: true }))
            })
            .addCase(SignInAsync.rejected, (state, action: any) => {
             
                Object.assign(state, {status: 'failed', error: action.payload as any})
            });
    }

});
export const { emptyUserError} = userSlice.actions;

export default userSlice.reducer;