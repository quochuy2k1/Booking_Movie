import { Actor } from '../slices/actor/actorSlice';
import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';

export interface ActorPagingRequest{
    PageIndex: number, 
    PageSize: number, 
    Nationality?: string,
    SortBy?: number 
}

interface ActorsResponse<T> {
    result: T[],
    total: number,
}

export async function GetAllActorPaging(request: ActorPagingRequest) {
    const body: AxiosRequestConfig = {
        params:{
            PageIndex: request.PageIndex,
            PageSize: request.PageSize,
            Nationality: request.Nationality,
            SortBy: request.SortBy
        }
    }
    var response = http.get<ActorsResponse<Actor>>("/api/actors/paging/", body)

    return response;
    
    // }
}

export async function GetDetailActor(id: string) {
   
    var response = http.get<Actor>(`/api/actors/${id}`)

    return response;
    
    // }
}

export async function GetAllActor() {
   
    var response = http.get<Actor[]>(`/api/actors`)

    return response;
    
    // }
}