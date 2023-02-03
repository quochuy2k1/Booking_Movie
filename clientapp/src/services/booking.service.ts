import { BookingClientModel } from './../slices/bookings/BookingSliceClient';
import { BookingModel } from './../slices/bookings/BookingSlice';

import http from "../common/http-common";
import { BookingSeatNo } from '../slices/seats/seatReservedSlice';



export interface BookingCombo {

    comboId: number,
    quantity: number,
    total: number

}
export interface BookingTicket {


    ticketId: number,
    quantity: number,
    total: number


}



export interface ExtraData extends Partial<BookingClientModel>{
    screeningId: number,
    bookingCombo: BookingCombo[],
    bookingTicket: BookingTicket[],
    bookingSeatNo: Partial<BookingSeatNo>[]
}
export interface BookingCreateRequest {
    orderInfo: string,
    amount: number,
    extraData: ExtraData,
    token?: string
}

export interface PaymentStatusUpdateRequest{
    status: boolean,
    orderId: string | undefined,
    token?: string
}

export async function GetAllBookingPaging() {

    var response = http.get<BookingModel[]>(`/api/bookings/get-all-booking`)

    return response;

    // }
}

export async function CreateBooking(request: Partial<BookingCreateRequest>) {
    const body: Partial<BookingCreateRequest> = {
        orderInfo: request.orderInfo,
        amount: request.amount,
        extraData: request.extraData
    }

    console.log(request.token, "request token")

    var response = http.post<string>("/api/bookings/momo-payment/", body, {
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json',
                'Authorization': `Bearer ${request.token}`,
                'CrossOrigin': "true",
                'Mode': 'cors',
            }
        })
    console.log("create api server")
    return response;

        // }
    }


    export async function UpdatePaymentStatus(request: PaymentStatusUpdateRequest) {
    

        const body: Partial<PaymentStatusUpdateRequest> = {
            status: request.status,
        }
        
       
        var response = http.patch<BookingModel>(`/api/bookings/${request.orderId}/update-payment-status`, body, {
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json',
                'Authorization': `Bearer ${request.token}`,
                'WithCredentials': "true",
                'CrossOrigin': "true",
                'Mode': 'no-cors',
            }
        })
        console.log("create api server")
        return response;
    
        // }
    }

    