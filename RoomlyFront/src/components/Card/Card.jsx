import React from "react";
import "./Card.css"

import classImg from "../../assets/images/salacard.jpg"

const Card = () => {
    return (
        <div className="class-card">
            <div className="left-side-card">
                <img src={classImg} className="class-card-img" alt="" />
            </div>

            <div className="right-side-card">
                <p className="title-card"> Sala 21 </p>
                <p className="title-text-card"> Capacidade: </p>
                <p className="text-card"> 40 alunos </p>

                <ul>
                    <p className="title-text-card"> Equipamentos: </p>
                    <p className="text-card"> Quadro branco </p>
                    <p className="text-card"> Projetor </p>
                    <p className="text-card"> Ar-condicionado </p>
                </ul>
            </div>
        </div>
    )
}

export default Card;