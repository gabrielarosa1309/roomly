--DML Database Manipulation Language

USE [Roomly]

--inserção de dados

INSERT INTO TiposUsuario (IdTipoUsuario,TituloTipoUsuario)
VALUES (NEWID(),'Administrador'),(NEWID(),'Professor'),(NEWID(),'Aluno')

INSERT INTO Equipamentos (IdEquipamento,TituloEquipamento)
VALUES (NEWID(),'Quadro Branco'),(NEWID(),'Ar-Condicionado'),(NEWID(),'Projetor')

INSERT INTO Usuario(IdUsuario,IdTipoUsuario,Nome,Email,Senha)
VALUES (NEWID(),'C43732BB-6567-440F-B725-20FA49BF5E79','Carlos','admin@admail.com','admin1234'),(NEWID(),'EC34D08A-1416-403A-AD87-C416E9FB50C5','Gabriela','gabi@profmail.com','prof1234'),(NEWID(),'769BC2AB-E978-4A3C-B8DD-83A6CD948FF3','João Victor','joaovictor@alunomail.com','aluno1234')

INSERT INTO Sala(IdSala,IdEquipamento,TituloSala,Capacidade)
VALUES (NEWID(),'B4800B82-DB4D-4410-A41D-3659CB06D3EC','Sala 21',40)

INSERT INTO Reserva(IdReserva,IdSala,IdUsuario,DataReserva,HorarioReserva)
VALUES (NEWID(),'AE48B040-C00D-4983-B5FA-F59802AC01C0','1CF34186-FE9E-4201-8F36-AF5D55FA8890','2024-12-12','10:30:00')
