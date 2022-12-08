import { ProducerModel } from './../slices/producers/producerSlice';
import http from "../common/http-common";


export async function GetAllProducer() {
   
    var response = http.get<ProducerModel[]>(`/api/producers`)

    return response;
    
    // }
}