import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { useNavigate } from "react-router-dom";
import { Login } from "../store/state/LoginSlice";
import { changeLogged } from "../store/state/ProfileSlice";
import css from "../cssformodules/LoginPage.module.css"
import {Link} from 'react-router-dom'

function RegisterForm() {
    const dispatch = useDispatch()
    /* const user = useSelector((state) => state.Login)
    const profile = useSelector((state)=> state.Profile) */
    const navigate = useNavigate()

    const [details, setDetails] = useState({
        username: "",
        password: "",
    })

    const handleChange = (e) => {
        const name = e.target.name
        const value = e.target.value
        setDetails((set)=> {return{...set, [name]: value}})
    }
    const handleSubmit = (e) => 
    {
        dispatch(Login(details))
        navigate("/")
    }

return(

    <div id={css.LoginContainer}>
        <Link to={'/'} className={css.icon}>
        <svg xmlns="http://www.w3.org/2000/svg" x="0px" y="0px" width="30" height="30" viewBox="0 0 48 48">
        <path d="M 24 2.9980469 C 23.042162 2.9980469 22.084349 3.3309171 21.316406 3.9941406 L 3.7871094 19.132812 A 1.0001 1.0001 0 0 0 3.7832031 19.134766 C 3.0520846 19.7701 2.8689211 20.781262 3.1621094 21.568359 C 3.4552977 22.355457 4.2597544 23 5.2304688 23 L 8 23 L 36 23 A 1.0001 1.0001 0 1 0 36 21 L 8 21 L 5.2304688 21 C 5.0811829 21 5.0689211 20.95454 5.0371094 20.869141 C 5.0052974 20.783741 4.9868251 20.739151 5.0957031 20.644531 L 22.623047 5.5058594 C 23.419161 4.8183063 24.580839 4.8183063 25.376953 5.5058594 L 32.345703 11.527344 A 1.0001 1.0001 0 0 0 34 10.769531 L 34 6 L 37 6 L 37 15.089844 A 1.0001 1.0001 0 0 0 37.345703 15.847656 L 42.904297 20.644531 C 43.013175 20.739151 42.994701 20.783738 42.962891 20.869141 C 42.931083 20.954543 42.918817 21 42.769531 21 L 40 21 A 1.0001 1.0001 0 0 0 39 22 L 39 42 C 39 42.56503 38.56503 43 38 43 L 31 43 C 30.43497 43 30 42.56503 30 42 L 30 32 C 30 30.354545 28.645455 29 27 29 L 21 29 C 19.354545 29 18 30.354545 18 32 L 18 42 C 18 42.56503 17.56503 43 17 43 L 10 43 C 9.4349698 43 9 42.56503 9 42 L 9 26 A 1.0001 1.0001 0 1 0 7 26 L 7 42 C 7 43.64497 8.3550302 45 10 45 L 17 45 C 18.64497 45 20 43.64497 20 42 L 20 32 C 20 31.445455 20.445455 31 21 31 L 27 31 C 27.554545 31 28 31.445455 28 32 L 28 42 C 28 43.64497 29.35503 45 31 45 L 38 45 C 39.64497 45 41 43.64497 41 42 L 41 23 L 42.769531 23 C 43.740246 23 44.544702 22.355457 44.837891 21.568359 C 45.131079 20.781262 44.947919 19.770146 44.216797 19.134766 A 1.0001 1.0001 0 0 0 44.212891 19.132812 L 39 14.632812 L 39 6 C 39 4.9045455 38.095455 4 37 4 L 34 4 C 32.904545 4 32 4.9045455 32 6 L 32 8.5859375 L 26.683594 3.9941406 C 25.915651 3.3309171 24.957838 2.9980469 24 2.9980469 z"></path>
        </svg>
        </Link>
    <h1>Login</h1>
        <form id={css.formstyle}>
            <div id={css.usernameinput}>
            <label htmlFor="username">Username</label>
            <input type="text" name="username" onChange={handleChange}/>
            </div>
            <div id={css.passwordinput}>
            <label htmlFor="password">Password</label>
            <input type="text" name="password" onChange={handleChange}/>
            </div>
            <input type="button" value="Log in" onClick={handleSubmit}/>

        </form>
        <h6 id={css.h6}>Don't have an account? <Link id="linktoregister" to="/register">Sign in</Link></h6>
    </div>)
}

export default RegisterForm

