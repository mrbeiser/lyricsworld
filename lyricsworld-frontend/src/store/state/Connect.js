import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import api from "../../smallApi/axiosApi";

export const getAllFromConnect = createAsyncThunk('allData', async () => {

    const Iresponse = await api.get("http://localhost:5159/api/Connection/GetAll")
    console.log(Iresponse)
    return Iresponse.data
    
})


export const ConnectDB = createSlice({
    name: "ConnectDB",
    initialState:
    {
        data: [],
        error: '',
    },
    extraReducers: (builder) => {
        builder
        .addCase(getAllFromConnect.pending, () => {console.log("searching all data")})
        .addCase(getAllFromConnect.fulfilled, (state, action) => {state.data = action.payload; console.log(action.payload)})
        .addCase(getAllFromConnect.rejected, (state,action)=> {state.data = {}; state.error=action.error.message})
    }
})
export default ConnectDB.reducer