import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';
import { CinemaModel } from "../slices/cinema/cinemaSlice";

export interface CinemaPagingRequest{
    PageIndex: number, 
    PageSize: number, 
    Name?: string,
    SortBy?: number 
}

interface CinemaResponse<T> {
    result: T[],
    total: number,
}

export async function GetAllCinemaPaging(request: CinemaPagingRequest) {
    const body: AxiosRequestConfig = {
        params:{
            PageIndex: request.PageIndex,
            PageSize: request.PageSize,
            Name: request.Name,
            SortBy: request.SortBy
        }
    }
    var response = http.get<CinemaResponse<CinemaModel>>("/api/cinemas/paging/", body)

    return response;
    
    // }
}