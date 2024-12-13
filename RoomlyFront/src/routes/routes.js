import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";

//import das páginas
import SignInUpPage from "../pages/SignInUpPage/SignInUpPage";
import HomePage from "../pages/HomePage/HomePage";

const Rotas = () => {
    return (
        <>
            <BrowserRouter>
                <Routes> 
                    <Route element={<SignInUpPage/>} path="/" exact/>
                    <Route element={<HomePage/>} path="/home"/>
                </Routes>
            </BrowserRouter>
        </>
    );
}

export default Rotas;