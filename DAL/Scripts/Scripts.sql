CREATE DATABASE EstudiantesDb
GO

USE EstudiantesDb
GO
CREATE TABLE Estudiantes
(
  Id int primary key identity,
  Estudiante varchar (30),
  Fecha date,
);

