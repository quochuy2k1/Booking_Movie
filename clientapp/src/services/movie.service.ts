import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';
import { ScreeningModel } from "../slices/screenings/ScreeningSlice";
import { MovieModel } from "../slices/movie/movieSlice";

export interface MoviePagingRequest {
    PageIndex: number,
    PageSize: number,
    Nationality?: string,
    Status?: number,
}

export interface MovieCreateRequest {
    imagePreview?: File,
    imageBackground?: File,
    videoTrailer?: File,
    name: string,
    alias: string,
    duration: number,
    releaseDate: string,
    content: string,
    status: boolean,
    nationality: string,
    producer: string,
    actorId?: string[],
    directorId?: string[],
    categoryId?: string[],
    token?: string
}

export interface MovieUpdateRequest {
    id: number,
    imagePreview?: File,
    imageBackground?: File,
    videoTrailer?: File,
    name?: string,
    alias?: string,
    duration?: number,
    releaseDate?: string,
    content?: string,
    status?: boolean,
    nationality?: string,
    producer?: string,
    actorId?: string[],
    directorId?: string[],
    categoryId?: string[],
    token?: string
}

export interface MovieDeleteRequest{
    id: number[],
    token: string
}

interface MoviesResponse<T> {
    result: T[],
    total: number,
}

export async function GetAllMoviePaging(request: MoviePagingRequest) {
    const body: AxiosRequestConfig = {
        params: {
            PageIndex: request.PageIndex,
            PageSize: request.PageSize,
            Nationality: request.Nationality,
            Status: request.Status,
        }
    }
    var response = http.get<MoviesResponse<MovieModel>>("/api/movies/paging/", body)

    return response;

    // }
}
export async function GetDetailMovie(id: string) {

    var response = http.get<MovieModel>(`/api/movies/detail/${id}`)

    return response;

    // }
}

export async function GetMovieCategories(id: string) {

    var response = http.get<MovieModel>(`/api/movies/${id}/get-movie-category`)

    return response;

    // }
}

export async function GetMovieDirectors(id: string) {

    var response = http.get<MovieModel>(`/api/movies/${id}/get-movie-director`)

    return response;

    // }
}

export async function GetCasts(id: string) {

    var response = http.get<MovieModel>(`/api/movies/${id}/cast`)

    return response;

    // }
}


export async function GetScreeningByMovieId(id: string) {

    var response = http.get<ScreeningModel[]>(`/api/movies/${id}/screening`)

    return response;

    // }
}

export async function GetAllScreening() {

    var response = http.get<ScreeningModel[]>(`/api/movies/screening`)

    return response;

    // }
}

export async function CreateMovie(request: MovieCreateRequest) {
    // const body: any = {

    //     Name: request.name,
    //     Alias: request.alias,
    //     Duration: request.duration,
    //     ReleaseDate: request.releaseDate,
    //     Content: request.content,
    //     Status: request.status,
    //     NationalityId: request.nationality,
    //     ProducerId: request.producer,
    //     ImagePreview: request.imagePreview,
    //     ImageBackground: request.imageBackground,
    //     VideoTrailer: request.videoTrailer,

    // }

    var data = new FormData();
    data.append("Name", request.name);
    data.append("Alias", request.alias);
    data.append("Duration", request.duration.toString());
    data.append("ReleaseDate", request.releaseDate);
    data.append("Content", request.content);
    data.append("Status", request.status.toString());
    data.append("NationalityId", request.nationality);
    data.append("ProducerId", request.producer);
    request.imagePreview && data.append("ImagePreview", request.imagePreview);
    request.imageBackground && data.append("ImageBackground", request.imageBackground);
    request.videoTrailer && data.append("VideoTrailer", request.videoTrailer);
    
    request.actorId && request.actorId.forEach(actor => {
        data.append("ActorId[]", actor);

    });
    request.directorId && request.directorId.forEach(director => {
        data.append("DirectorId[]", director);


    });
    request.categoryId && request.categoryId.forEach(category => {
        data.append("CategoryId[]", category);


    });
    var response = http.post<MovieModel>("/api/movies/create/", data, {
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

export async function UpdateMovie(request: MovieUpdateRequest) {
   

    var data = new FormData();
    request.name && data.append("Name", request.name);
    request.alias && data.append("Alias", request.alias);
    request.duration && data.append("Duration", request.duration.toString());
    request.releaseDate && data.append("ReleaseDate", request.releaseDate);
    request.content && data.append("Content", request.content);
    request.status && data.append("Status", request.status.toString());
    request.nationality && data.append("NationalityId", request.nationality);
    request.producer && data.append("ProducerId", request.producer);
    request.imagePreview && data.append("ImagePreview", request.imagePreview);
    request.imageBackground && data.append("ImageBackground", request.imageBackground);
    request.videoTrailer && data.append("VideoTrailer", request.videoTrailer);
    
    request.actorId && request.actorId.forEach(actor => {
        data.append("ActorId[]", actor);

    });
    request.directorId && request.directorId.forEach(director => {
        data.append("DirectorId[]", director);


    });
    request.categoryId && request.categoryId.forEach(category => {
        data.append("CategoryId[]", category);


    });
    var response = http.put<MovieModel>(`/api/movies/${request.id}/update/`, data, {
        headers: {
            'Content-Type': 'multipart/form-data',
            'Accept': 'application/json',
            'Authorization': `Bearer ${request.token}`,
            'WithCredentials': "true",
            'CrossOrigin': "true",
            'Mode': 'no-cors',
        }
    })
    console.log(request.token, "update api server")
    return response;

    // }
}



export async function DeleteMovie(request: MovieDeleteRequest) {

    var response = http.delete<number[]>(`/api/movies/del`, { headers: {
        'Authorization': `Bearer ${request.token}`,

    }, data: request.id}, );

    return response;

    // }
}