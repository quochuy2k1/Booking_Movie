import { ScreeningModel } from "../slices/screenings/ScreeningSlice";
import http from "../common/http-common";
import { AxiosRequestConfig } from "axios";
import { ScreeningTypeModel } from "../slices/screenings/screeningTypeSlice";


export interface ScreeningCreateRequest extends ScreeningModel {
    token: string
}


export async function CreateScreening(request: ScreeningCreateRequest) {
    

    var data = new FormData();
    data.append("cinemaId", request.cinemaId.toString());
    data.append("auditoriumId", request.auditoriumId.toString());
    request.movieId && data.append("movieId", request.movieId.toString());
    data.append("screeningTypeId", request.screeningTypeId.toString());
    data.append("dateFrom", request.dateFrom);
    data.append("dateTo", request.dateTo);

    request.showTimeId.forEach((value, index) => {
        data.append("showTimeId[]", value);

    });
    
    
   
    var response = http.post<ScreeningModel>("/api/Screenings/add-new", data, {
        headers: {
            'Content-Type': 'multipart/form-data',
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

//#region screening_type

export interface ScreeningTypePagingRequest{
    PageIndex: number, 
    PageSize: number, 
    SortBy?: number 
}

interface ScreeningTypesResponse<T> {
    result: T[],
    total: number,
}


export async function GetAllScreeningTypePaging(request: ScreeningTypePagingRequest) {
    const body: AxiosRequestConfig = {
        params:{
            PageIndex: request.PageIndex,
            PageSize: request.PageSize,
            SortBy: request.SortBy
        }
    }
    var response = http.get<ScreeningTypesResponse<ScreeningTypeModel>>("/api/ScreeningTypes/paging/", body)

    return response;
    
    // }
}
//#endregion