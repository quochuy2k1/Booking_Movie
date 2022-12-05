import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';
import { ScreeningModel } from "../slices/screenings/ScreeningSlice";
import { MovieModel } from "../slices/movie/movieSlice";

export interface MoviePagingRequest{
    PageIndex: number, 
    PageSize: number,
    Nationality?: string, 
    Status?: number,
}

interface MoviesResponse<T> {
    result: T[],
    total: number,
}

export async function GetAllMoviePaging(request: MoviePagingRequest) {
    const body: AxiosRequestConfig = {
        params:{
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

export async function GetScreeningByMovieId(id: string) {
    
    var response = http.get<ScreeningModel[]>(`/api/movies/${id}/screening`)

    return response;
    
    // }
}
