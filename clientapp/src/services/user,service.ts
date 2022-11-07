import http from "../common/http-common";
import { UserState } from "../features/user/userSlice";
export async function SignIn(UserName: string, Password: string) {
    const body = {
        UserName,
        Password
    }
    var response = http.post<UserState>("/user/signin", body)

    return response;
    
    // }
}