import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { useEffect } from "react";
import { render } from "@testing-library/react";
import { useNavigate, Navigate } from "react-router-dom";
import {GetProfile} from '../store/state/ProfileSlice'
import { Link } from "react-router-dom";
import css from '../cssformodules/Profile.module.css'
import Header from "./Header";
function AdminButton(){
    return (
        <button><Link to="/">AdminPanel</Link></button>
    )
}

function Profile()
{
    const navigate = useNavigate()
    let username = localStorage.getItem('username')
    const dispatch = useDispatch()
    useEffect(()=>{dispatch(GetProfile(username))}, [])
    const profile = useSelector((state)=>state.Profile).userData
    
 
    if(username == null)
    {
        return <Navigate to={'/login'}></Navigate>
    }
    const logout = () => {localStorage.clear(); navigate("/")}
        

    return(
        <div className={css.profilecontainer}>
            <Header />
            <div className={css.profileheader}>
                <div className={css.username}>{profile.userName}</div>
                {/* TODO: normal profile picture */}
                <div className={css.profilepic}><img src={profile.userProfilePicture} alt="profile picture" /></div>
            </div>
            <div className={css.userstats}>
                <div className={css.likes}>User likes: {profile.userLikes}</div>
            </div>
            <button onClick={logout}>Log out</button>
        </div>
    )
}


export default Profile