import { BookingModel } from './../slices/bookings/BookingSlice';

import http from "../common/http-common";



export async function GetAllBookingPaging() {
    
    var response = http.get<BookingModel[]>(`/api/bookings/get-all-booking`)

    return response;
    
    // }
}