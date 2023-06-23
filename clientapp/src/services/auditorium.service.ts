import { AuditoriumModel, IAuditoriumBaseModel } from '../slices/auditoriums/AuditoriumSlice';
import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';
import { ISeatNoChangeAction } from '../admin/views/pages/management/auditorium/auditorium';


export interface AuditoriumPagingRequest{
    PageIndex: number, 
    PageSize: number, 
    CinemaId?: string,
    SortBy?: number 
}

interface AuditoriumResponse<T> {
    result: T[],
    total: number,
}

export async function GetAllAuditoriumPaging(request: AuditoriumPagingRequest) {
    const body: AxiosRequestConfig = {
        params:{
            PageIndex: request.PageIndex,
            PageSize: request.PageSize,
            CinemaId: request.CinemaId,
            SortBy: request.SortBy
        }
    }
    var response = http.get<AuditoriumResponse<IAuditoriumBaseModel>>("/api/auditoriums/paging/", body)

    return response;
    
    // }
}

export async function GetSeatByAuditorium(id: string) {
    
    var response = http.get<AuditoriumModel[]>(`/api/auditoriums/${id}/seat-no/`)

    return response;
    
    // }
}

export async function SeatNoSaveChanage(auditoriumId: string, token: string, request: ISeatNoChangeAction[]) {
    const body: any = {
        seatNoActions: [...request]
    }

    console.log(token, "request token")

    var response = http.post<any>(`/api/Auditoriums/${auditoriumId}/save-changes`, body, {
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json',
            'Authorization': `Bearer ${token}`,
            'CrossOrigin': "true",
            'Mode': 'cors',
        }
    })
    console.log("create api server")
    return response;

    // }
}