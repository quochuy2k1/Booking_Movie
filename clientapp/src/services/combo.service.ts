import http from "../common/http-common";
import { Combo } from "../slices/combos/comboSlice";




export async function GetAllCombo() {
   
    var response = http.get<Combo[]>("/api/combos/");

    return response;
    
    // }
}