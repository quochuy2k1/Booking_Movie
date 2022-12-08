import { NationalityModel } from './../slices/nationalities/nationalitySlice';
import http from "../common/http-common";


export async function GetAllNationalities() {
   
    var response = http.get<NationalityModel[]>(`/api/nationalities/get-all`)

    return response;
    
    // }
}