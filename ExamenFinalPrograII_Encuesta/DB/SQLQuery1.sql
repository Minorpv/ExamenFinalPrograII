CREATE DATABASE encuestaPartido
GO
USE encuestaPartido
GO

create TABLE partidos
(
	id int identity (1,1) PRIMARY KEY,
	nombre VARCHAR(20)
)
GO

INSERT INTO partidos VALUES ('PUSC'), ('PLN'), ('PAC')
GO
SELECT * FROM partidos
GO

CREATE TABLE encuesta
(
	ID int identity (1,1) NOT NULL PRIMARY KEY,
	Nombre VARCHAR (50) NOT NULL,
	Edad int NOT NULL,
	Correo varchar(50) NOT NULL,
	Partido int,
	CONSTRAINT fk_partido FOREIGN KEY (Partido) REFERENCES partidos(id),
)
GO

CREATE PROCEDURE agregarEncuesta
@NOMBRE VARCHAR(50),
@EDAD INT,
@CORREO VARCHAR(50),
@PARTIDO INT
AS
	BEGIN
		INSERT INTO encuesta VALUES (@NOMBRE, @EDAD, @CORREO, @PARTIDO)
	END
GO