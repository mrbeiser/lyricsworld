import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const Register = createAsyncThunk('user/register', async (details) => {

    let username = details.username 
    let password = details.password
    let email = details.email

    const Iresponse = await axios.post("http://localhost:5159/api/User/RegisterUser/", 
    {
        username,
        password,
        email
    })
    return Iresponse.data
})


export const RegisterSlice = createSlice({
    name: "user",
    initialState:
    {
        username: '',
        password: '',
        email: '',
        error: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(Register.pending, () => {console.log("fetching data")})
        .addCase(Register.fulfilled, (state, action) => {state.username =action.payload.username; console.log(action.payload.username+" added")})
        .addCase(Register.rejected, (state,action)=> {state.error=action.error.message})
    }
})

export default RegisterSlice.reducer