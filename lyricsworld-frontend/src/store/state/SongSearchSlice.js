import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import api from "../../smallApi/axiosApi";

export const search = createAsyncThunk('searchsong', async (details) => {

    let value = details 
    const Iresponse = await api.get("http://localhost:5159/api/Song/GetSongByTitle/"+value)
    return Iresponse.data
})


export const SearchSong = createSlice({
    name: "searchsong",
    initialState:
    {
        songs: [],
        error: '',
    },
    reducers: {
        clearSongs(state){
            state.songs = []
        }
    },
    extraReducers: (builder) => {
        builder
        .addCase(search.pending, () => {console.log("searching for song")})
        .addCase(search.fulfilled, (state, action) => {state.songs = action.payload})
        .addCase(search.rejected, (state,action)=> {state.songs = []})
    }
})
export const {clearSongs} = SearchSong.actions
export default SearchSong.reducer