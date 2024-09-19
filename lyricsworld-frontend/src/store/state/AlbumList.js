import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";


export const getAlbums = createAsyncThunk('album/fetch', async () => {
    const curToken = localStorage.getItem('token')
    const Iresponse = await axios.get("http://localhost:5159/api/Albums/GetAlbums/", {headers: {"Authorization": "Bearer "+curToken}})
    return Iresponse
})


export const AlbumList = createSlice({
    name: "album",
    initialState:
    {
        data: [],
        error: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(getAlbums.pending, () => {console.log("fetching data")})
        .addCase(getAlbums.fulfilled, (state, action) => {state.data =action.payload.data})
    }
})

export default AlbumList.reducer