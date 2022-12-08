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
    sessionId: string
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
    sessionId: ""
}

export const SignInAsync = createAsyncThunk(
    'user/SignIn',
    async (UserData: { UserName: string, Password: string }, { rejectWithValue }) => {
        const { UserName, Password } = UserData;
        try {
            const response = await SignIn(UserName, Password);
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
            .addCase(SignInAsync.rejected, (state) => {
                state.status = 'failed';
            });
    }

});
// export const { } = userSlice.actions;

export default userSlice.reducer;