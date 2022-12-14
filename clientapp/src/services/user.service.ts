import http from "../common/http-common";
import { UserState } from "../slices/user/userSlice";
export async function SignIn(UserName: string, Password: string, Remember: boolean) {
    const body = {
        UserName,
        Password,
        Remember
    }
    var response = http.post<UserState>("/user/signin", body)

    return response;
    
    // }
}