import React from "react";
import "./HomePage.css"

import profileImage from "../../assets/images/chewieadm.jpg"
import logo from "../../assets/images/Roomly.png"
import Card from "../../components/Card/Card"

const HomePage = () => {
    return (
        <div className="layout-grid-home">
            <div className="left-side-home">
                <div className="user">
                    <img src={profileImage} className="user-img" alt="" />
                    <h1 className="user-name"> Chewie </h1>
                    <p className="user-type"> Administrador </p>
                    <button className="new-class-button"> Nova sala </button>
                </div>
            </div>

            <div className="right-side-home">
                <img src={logo} className="logo" alt="" />
                <h1 className="greetings-title"> Olá, Chewie! Como podemos te ajudar hoje? </h1>


                <div className="available-classes">
                    <h1 className="row-title"> Salas disponíveis </h1>
                    <div className="classes-row">
                        <Card></Card>
                    </div>
                </div>

                <div className="reserved-classes">
                    <h1 className="row-title"> Salas reservadas anteriormente </h1>
                    <div className="classes-row">
                        <Card></Card>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default HomePage;