--CREATE DATABASE MiPrimeraVez
--	ON PRIMARY 
--	(
--		NAME = MiPrimeraVez_data,
--		FILENAME = 'C:\disk1\MiPrimeraVez_data.mdf'
--	),
--	LOG ON
--	(
--	   NAME = MiPrimeraVez_log,
--	   FILENAME = 'C:\disk3\MiPrimeraVez_log.ldf'
--	)
--GO

USE MiPrimeraVez
Go

CREATE TABLE Mercaderia
(
	IdMercancia INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	Descripcion VARCHAR(120) NOT NULL,
	Existencia INT DEFAULT 0 CHECK (Existencia >= 0) NULL,
	Comentario TEXT NOT NULL,
	Status varchar(8) NULL DEFAULT 'Activa',
	NoEliminable BIT DEFAULT 0 NULL
);
GO

CREATE NONCLUSTERED INDEX idx_Descripcion 
	ON Mercaderia (Descripcion)
GO

------- HACIENDO VALIDACIONES CON CHECK ---------

ALTER TABLE Mercaderia ADD CONSTRAINT ck_status
	CHECK (Mercaderia.Status IN ('Activa','Inactiva'))
GO

--SOLO PRUEBA INSERCION DATA.
INSERT INTO Mercaderia ([Descripcion],[Existencia],[Comentario],[Status],[NoEliminable]) 
VALUES ('Keyboard RGB Z1500',20,'Teclado de luces para Gaming.','Inactiva',3232)

SELECT *
FROM Mercaderia