import { AuditoriumModel } from '../slices/auditoriums/AuditoriumSlice';
import http from "../common/http-common";


export async function GetSeatByAuditorium(id: string) {
    
    var response = http.get<AuditoriumModel[]>(`/api/auditoriums/${id}/seat-no/`)

    return response;
    
    // }
}