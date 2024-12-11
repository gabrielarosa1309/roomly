--DML Database Manipulation Language

USE [Roomly]

--inserção de dados

INSERT INTO TiposUsuario (TituloTipoUsuario)
VALUES ('Administrador'),('Professor'),('Aluno')

INSERT INTO Equipamentos (TituloEquipamento)
VALUES ('Quadro Branco'),('Ar-Condicionado'),('Projetor')

INSERT INTO Usuario(IdTipoUsuario,Nome,Email,Senha)
VALUES (1,'Carlos','admin@admail.com','admin1234'),(2,'Gabriela','gabi@profmail.com','prof1234'),(3,'João Victor','joaovictor@alunomail.com','aluno1234')

INSERT INTO Sala(IdEquipamento,TituloSala,Capacidade)
VALUES (1,'Sala 21',40)

INSERT INTO Reserva(IdSala,IdUsuario,DataReserva,HorarioReserva)
VALUES (1, 1, '2024-12-12', '10:30:00')
