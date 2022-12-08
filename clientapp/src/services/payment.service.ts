import http from "../common/http-common";
import { PaymentModel } from "../slices/payments/PaymentSlice";




export async function GetAllPayment() {
   
    var response = http.get<PaymentModel[]>("/api/paymentmethods/get-payment-methods");

    return response;
    
    // }
}