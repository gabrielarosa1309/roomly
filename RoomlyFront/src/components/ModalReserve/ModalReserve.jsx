import React, { useContext, useEffect, useState } from "react";
import "./ModalReserve.css";

import { UserContext } from "../../context/AuthContext";
import { Button, Input } from "../FormComponents/FormComponents";

const ModalReserve = ({
  modalTitle = "Feedback",
  showHideModal = false,
  fnGet = null,
  fnPost = null,
}) => {
  const {userData} = useContext(UserContext);

  useEffect (() => {
    async function carregarDados() {
      const obj = await fnGet(userData.idEvento)
    }

    carregarDados();
  } , [newComentary]);

  return (
    <div className="modal">
      <article className="modal__box">
        
        <h3 className="modal__title">
          {modalTitle}
          <span className="modal__close" onClick={()=> showHideModal(true)}>x</span>
        </h3>

        <Input
          placeholder="Escreva seu comentário..."
          additionalClass = "comentary__entry"
          type={"text"}
          required={"required"}

          manipulatorFunction={(e) => {setNewComentary(e.target.value)}}
          value={newComentary}
        />

        <Button
          textButton="Reservar"
          additionalClass = "comentary__button"
          manipulationFunction={fnPost}
        />
      </article>
    </div>
  );
};

export default ModalReserve;