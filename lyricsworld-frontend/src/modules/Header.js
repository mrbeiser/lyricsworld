import React, {Component} from "react";
import logo from "../media/logo.png"
import profilePic from "../media/user.svg"
import css from "../cssformodules/HeaderModule.module.css"
import { Link, useNavigate } from "react-router-dom";




function Header(){
    
        const navigate = useNavigate()

        return (
            <header id={css.header}>
            
            <Link to="/" className={css.HomeButton}><img src={logo} alt="logo of lyricsworld" className={css.Logo}></img></Link>
            <button className={css.ProfileButton}>
                <div className={css.coloredbutton}>
                <object type="image/svg+xml" data={profilePic}></object>
                <Link className={css.coloredbuttontext} to={"/profile"}>Profile</Link>
                </div>  
            </button>
            <style>
                
            </style>
            </header>

            
        );
    
}

export default Header