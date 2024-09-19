import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import api, {baseURL} from '../../smallApi/axiosApi'
export const getArtists = createAsyncThunk('artist/fetch', async () => {
    const Iresponse = await api.get(baseURL+"/Artists/GetArtist/")
    return Iresponse.data
})

export const ArtistsList = createSlice({
    name: "artist",
    initialState:
    {
        data: [],
        error: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(getArtists.pending, () => {console.log("fetching data")})
        .addCase(getArtists.fulfilled, (state, action) => {state.data =action.payload})
    }
})

export default ArtistsList.reducer