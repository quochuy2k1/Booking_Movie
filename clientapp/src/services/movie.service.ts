import http from "../common/http-common";
import { AxiosRequestConfig } from 'axios';
import { Movie } from "../features/movie/movieSlice";
import { MovieDetailState } from "../features/movie/MovieDetail";
import { ScreeningState } from "../components/movies/Sreening";

export interface MoviePagingRequest{
    PageIndex: number, 
    PageSize: number, 
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
            Status: request.Status,
        }
    }
    var response = http.get<MoviesResponse<Movie>>("/api/movies/paging/", body)

    return response;
    
    // }
}
export async function GetDetailMovie(id: string) {
    
    var response = http.get<MovieDetailState>(`/api/movies/detail/${id}`)

    return response;
    
    // }
}

export async function GetScreeningByMovieId(id: number) {
    
    var response = http.get<ScreeningState[]>(`/api/movies/${id}/screening`)

    return response;
    
    // }
}
