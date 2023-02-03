import { Actor } from '../slices/actor/actorSlice';
import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';

export interface ActorPagingRequest{
    PageIndex: number, 
    PageSize: number, 
    Nationality?: string,
    SortBy?: number 
}
export interface ActorImageModel{
    id: number,
    actorId: string,
    imagePath: string,
    caption: string,
    isDefault: boolean,
    dateCreated: string,
    sortOrder: number,
    fileSize: number
}

interface ActorsResponse<T> {
    result: T[],
    total: number,
}

export interface ActorCreateRequest{
    name: string,
    height: number,
    nationality: string | null,
    description: string,
    dateOfBirth: string,
    image: File | null,
    token: string
}
export interface ActorUpdateRequest{
    id: string,
    name?: string,
    height?: number,
    nationality?: string | null,
    description?: string,
    dateOfBirth?: string,
    image?: File | null,
    token: string
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
export async function GetAllActorImage(id: string) {
   
    var response = http.get<ActorImageModel[]>(`/api/actors/${id}/get-all-actor-image`)

    return response;
    
    // }
}


export async function CreateActor(request: ActorCreateRequest) {
    

    var data = new FormData();
    data.append("Name", request.name);
    data.append("Height", request.height.toString());
    data.append("DateOfBirth", request.dateOfBirth);
    data.append("Description", request.description);
    request.nationality && data.append("NationalityId", request.nationality);
    request.image && data.append("Image", request.image);
    
   
    var response = http.post<Actor>("/api/actors/create/", data, {
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

export async function UpdateActor(request: ActorUpdateRequest) {
    

    var data = new FormData();
    request.name && data.append("Name", request.name);
    request.height && data.append("Height", request.height.toString());
    request.dateOfBirth && data.append("DateOfBirth", request.dateOfBirth);
    request.description && data.append("Description", request.description);
    request.nationality && data.append("NationalityId", request.nationality);
    request.image && data.append("Image", request.image);
    
   
    var response = http.put<Actor>(`/api/actors/update/${request.id}`, data, {
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