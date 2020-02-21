CREATE DATABASE M_Peoples
GO 
USE M_Peoples
GO 
CREATE TABLE Funcionario (
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (200),
	Sobrenome VARCHAR (200)
);
GO
INSERT INTO Funcionario (Nome, Sobrenome)
VALUES ('Catarina', 'Strada'),
		('Tadeu', 'Vitelli');
GO
SELECT IdFuncionario, Nome, Sobrenome FROM Funcionario