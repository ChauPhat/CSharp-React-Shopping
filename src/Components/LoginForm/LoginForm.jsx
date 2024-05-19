import React from 'react';
import './LoginForm.css';
import { FaUserAlt,FaLock  } from "react-icons/fa";

const LoginForm = () =>{
    return(
        <div className='wrapper'>
            <form action=''>
                <h1>Login</h1>
                <div className="input-box">
                <FaUserAlt className='icon'/><input type="text" placeholder='Username' required/>
                </div>
                <div className="input-box">
                <FaLock className='icon' />   <input type="password" placeholder='Password'required/>
                </div>

                <div className="rember-forgot">
                    <label><input type="checkbox" />Remember me</label>
                    <a href="#">Forgot Password</a>
                </div>

                <button type='submit'>Login</button>
                <div className="register-link">
                    <p>Don't have an account?<a href="#"> Register</a></p>
                </div>
            </form>
        </div>
    );
};

export default LoginForm;
