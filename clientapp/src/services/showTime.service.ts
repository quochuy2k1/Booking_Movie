import { AxiosRequestConfig } from "axios";
import http from "../common/http-common";
import { ShowTimeModel } from "../slices/showTime/showTimeSlice";

export interface ShowTimePagingRequest{
    PageIndex: number, 
    PageSize: number, 
    SortBy?: number 
}

interface ShowTimeResponse<T> {
    result: T[],
    total: number,
}

export async function GetAllShowTimePaging(request: ShowTimePagingRequest) {
    const body: AxiosRequestConfig = {
        params:{
            PageIndex: request.PageIndex,
            PageSize: request.PageSize,
            SortBy: request.SortBy
        }
    }
    var response = http.get<ShowTimeResponse<ShowTimeModel>>("/api/showtimes/paging/", body)

    return response;
    
    // }
}