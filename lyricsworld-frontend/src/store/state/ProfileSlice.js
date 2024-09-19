import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import api from "../../smallApi/axiosApi";

export const GetProfile = createAsyncThunk('GetProfile/fetch', async (username) => 
    {
        let currId = username
        const response = await api.get("http://localhost:5159/api/User/GetUser/"+currId)
        return response.data
    })

export const ProfileSlice = createSlice({
    name: "profile",
    initialState:
    {
        userData: {},
        error: ''
    },
    
    extraReducers(builder){
        builder
        .addCase(GetProfile.pending, ()=> console.log("pending"))
        .addCase(GetProfile.fulfilled,(state,action)=> {state.userData=action.payload;})
    }
    
})


export default ProfileSlice.reducer