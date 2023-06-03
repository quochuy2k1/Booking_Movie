
import { IQRBookingScanner } from "../admin/views/pages/management/QRBookingScanner";
import { IHistoryBookingState } from "../client/features/user/BookingHistory";
import http from "../common/http-common";
import { UserState } from "../slices/user/userSlice";

export async function SignIn(UserName: string, Password: string, RememberMe: boolean) {
    const body = {
        UserName,
        Password,
        RememberMe
    }
    http.defaults.withCredentials = true;
    var response = http.post<UserState>("/api/users/signin", body)

    return response;
    
    // }
}

export async function SignOut() {
   
    var response = http.post<{isLogout: boolean}>("/api/Users/logout")

    return response;
    
    // }
}

export async function GetBookingByUser(userId: string, token: string) {
    

    var response = http.get<IHistoryBookingState[]>(`/api/Bookings/get-booking-history/user/${userId}`, {
        headers:{
            'Authorization': `Bearer ${token}`,
        }
    })

    return response;
    
    // }
}

export async function GetBookingByQrCode(qrContent: string, token: string) {

    var response = http.get<IQRBookingScanner>(`/api/Bookings/get-booking-qr-code?qrContent=${qrContent}`, {
        headers:{
            'Authorization': `Bearer ${token}`,
        }
    })

    return response;

    // }
}
export async function GetReportBookingByQrCode(qrContent: string, token: string) {

    var response = http.get<string>(`/api/Reports/cinema-ticket?qrContent=${qrContent}`, {
        headers:{
            'Authorization': `Bearer ${token}`,
        }
    })

    return response;

    // }
}