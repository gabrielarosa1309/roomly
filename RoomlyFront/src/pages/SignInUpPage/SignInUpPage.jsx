import React, { useState } from "react";
import "./SignInUpPage.css";

import loginImage from "../../assets/images/aulapng.png";
import loginLogo from "../../assets/images/Roomly.png"
import { Input, Button } from "../../components/FormComponents/FormComponents"

const SignInUpPage = () => {
    const [isSignUpMode, setIsSignUpMode] = useState(false);
   
    const handleSignUpClick = () => {
        setIsSignUpMode(true);
    };

    return (
        <div className="layout-grid-login">
            <div className="left-side-sign-in-up">
                <p className="paragraph-left-login">Simplifique a gestão de espaços: reserve, organize e conecte sua instituição com eficiência</p>
                <img src={loginImage} className="login-image" alt="" />
            </div>

            <div className="right-side-sign-in-up">
                <img src={loginLogo} className="login-logo" alt="" />

                <h1 className="title">{isSignUpMode ? 'Cadastro' : 'Login'}</h1>

                {isSignUpMode ? (
                    <div className="login-form">
                        <Input
                            additionalClass="sign-in-up-input"
                            type="email"
                            id="login"
                            name="login"
                            required={true}
                            //value={user.email}
                            //manipulationFunction={(e) => { setUser({ ...user, email: e.target.value.trim() }) }} //trim é uma função nativa utilizada para remover os espaçamentos do inicio e do fim da string
                            placeholder="Insira seu email"
                        />

                        <Input
                            additionalClass="sign-in-up-input"
                            type="senha"
                            id="login"
                            name="login"
                            required={true}
                            //value={user.email}
                            //manipulationFunction={(e) => { setUser({ ...user, email: e.target.value.trim() }) }} //trim é uma função nativa utilizada para remover os espaçamentos do inicio e do fim da string
                            placeholder="Insira sua senha"
                        />

                        <ul class="password-requirement">
                            <strong>Sua senha deve conter:</strong>
                            <p>Pelo menos uma letra maiúscula;</p>
                            <p>Pelo menos uma letra minúscula;</p>
                            <p>Pelo menos um número.</p>
                        </ul>
                    </div>
                ) : (
                    <div className="login-form">
                        <Input
                            additionalClass="sign-in-up-input"
                            type="email"
                            id="login"
                            name="login"
                            required={true}
                            //value={user.email}
                            //manipulationFunction={(e) => { setUser({ ...user, email: e.target.value.trim() }) }} //trim é uma função nativa utilizada para remover os espaçamentos do inicio e do fim da string
                            placeholder="Insira seu email"
                        />

                        <Input
                            additionalClass="sign-in-up-input"
                            type="senha"
                            id="login"
                            name="login"
                            required={true}
                            //value={user.email}
                            //manipulationFunction={(e) => { setUser({ ...user, email: e.target.value.trim() }) }} //trim é uma função nativa utilizada para remover os espaçamentos do inicio e do fim da string
                            placeholder="Insira sua senha"
                        />
                    </div>
                )}


                <Button
                    textButton={isSignUpMode ? 'Cadastrar' : 'Login'}
                    id="btn-login"
                    name="btn-login"
                    type="submit"
                    additionalClass="sign-in-up-button"
                />

                <div className="sign-up-link">
                    <p className="sign-up-link-text">  {isSignUpMode ? 'Já possui cadastro?' : 'Não possui cadastro?'}</p>
                    <button className="sign-up-link-click" onClick={handleSignUpClick} > {isSignUpMode ? 'Faça login!' : 'Cadastre-se!'}</button>
                </div>
            </div>
        </div>
    )
}

export default SignInUpPage;