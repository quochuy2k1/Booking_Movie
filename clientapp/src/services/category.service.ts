import { CategoryModel } from './../slices/categories/categorySlice';
import http from "../common/http-common";


export async function GetAllCategories() {
   
    var response = http.get<CategoryModel[]>(`/api/categories/get-all`)

    return response;
    
    // }
}