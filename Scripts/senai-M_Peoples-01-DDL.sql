CREATE DATABASE M_Peoples
GO 
USE M_Peoples
GO 
CREATE TABLE Funcionario (
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (200),
	Sobrenome VARCHAR (200)
);