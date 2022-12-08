import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { GetAllCategories } from "../../services/category.service";




export interface CategoryModel {
    id: number,
    name: string,
    description: string | null,
    parentId: number | null,
    displayOrder: number | null,
    image: string | undefined,
    homeFlag: boolean 
}

export interface CategoryState {
    categories: CategoryModel[],
    status: string
}

const initialState: CategoryState = {
    categories: [] as CategoryModel[],
    status:""
}


export const GetCategoriesAsync = createAsyncThunk(
    "category/getCategories",
    async (request,{rejectWithValue}) => {
        try {
            const response = await GetAllCategories();
            console.log(response.data, "async categories")

            // The value we return becomes the `fulfilled` action payload
            return response.data;
          }
          catch (err: any) {
            return rejectWithValue(err.response.data)
          }
    }
)


export const CategorySlice = createSlice({
    name: "category",
    initialState,
    reducers:{
        
    },
    extraReducers: (builder) => {
        builder.addCase(GetCategoriesAsync.pending, (state, action)=>{
            state.status = "loading";
        })
        .addCase(GetCategoriesAsync.fulfilled, (state, action) => {
            const categories = action.payload
            const status = "idle";
            Object.assign(state, {categories, status})
        })
        .addCase(GetCategoriesAsync.rejected, (state, action) => {
            state.status = "failed"
        })
    }
});


export default CategorySlice.reducer;