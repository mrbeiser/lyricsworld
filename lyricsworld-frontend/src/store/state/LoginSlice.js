import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const Login = createAsyncThunk('login', async (details) => {

    let username = details.username 
    let password = details.password

    const Iresponse = await axios.post("http://localhost:5159/api/User/Login/", 
    {
        username,
        password,   
    })
    return Iresponse.data
})


export const LoginSlice = createSlice({
    name: "userLogin",
    initialState:
    {
        username: '',
        error: '',
    },
    extraReducers: (builder) => {
        builder
        .addCase(Login.pending, () => {console.log("trying to log in")})
        .addCase(Login.fulfilled, (state, action) => {state.username =action.payload.username;localStorage.setItem('token', action.payload.jwt);localStorage.setItem('username', action.payload.username); })
        .addCase(Login.rejected, (state,action)=> {state.error=action.error.message})
    }
})
export default LoginSlice.reducer