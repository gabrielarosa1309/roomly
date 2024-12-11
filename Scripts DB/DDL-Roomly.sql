--DDL Database Definition Language

--criar banco de dados
CREATE DATABASE [Roomly]
USE [Roomly]

--criar tabelas
CREATE TABLE TiposUsuario
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario VARCHAR(20) NOT NULL
)

CREATE TABLE Equipamentos
(
	IdEquipamento INT PRIMARY KEY IDENTITY,
	TituloEquipamento VARCHAR(100) NOT NULL
)

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuario(IdTipoUsuario) NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Email VARCHAR(256) NOT NULL UNIQUE,
	Senha VARCHAR(100) NOT NULL
)

CREATE TABLE Sala
(
	IdSala INT PRIMARY KEY IDENTITY,
	IdEquipamento INT FOREIGN KEY REFERENCES Equipamentos(IdEquipamento) NOT NULL,
	TituloSala VARCHAR(50) NOT NULL,
	Capacidade INT NOT NULL
)

CREATE TABLE Reserva
(
	IdReserva INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
	IdSala INT FOREIGN KEY REFERENCES Sala(IdSala) NOT NULL,
	DataReserva DATE NOT NULL,
	HorarioReserva TIME NOT NULL
)
