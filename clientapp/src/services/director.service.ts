import http from "../common/http-common";
import { DirectorModel } from "../slices/directors/directorSlice";


export async function GetAllDirector() {
   
    var response = http.get<DirectorModel[]>(`/api/directors/get-all`)

    return response;
    
    // }
}