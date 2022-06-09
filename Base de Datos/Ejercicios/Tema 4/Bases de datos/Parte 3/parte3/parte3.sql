CREATE DATABASE parte3;
USE parte3;


CREATE TABLE mecenas (
	codigo INT,
    nombre VARCHAR(50),
    ciudad VARCHAR(20),
    pais VARCHAR(20)
);

CREATE TABLE autor (
	id INT,
    nombre VARCHAR(50),
    pais VARCHAR(20),
    fecha_nacimiento DATE,
    fecha_defuncion DATE 
);

CREATE TABLE patrocina (
	mecenas INT,
    autor INT,
    fecha_inicio DATE,
    fecha_fin DATE
);

CREATE TABLE maestro (
	maestro INT,
    aprendiz INT
);

CREATE TABLE obra (
	codigo INT,
    autor INT,
    titulo VARCHAR(50)
);

CREATE TABLE galeria(
	codigo INT,
    nombre VARCHAR(50),
    direccion VARCHAR(100),
    poblacion VARCHAR(50),
    provincia VARCHAR(50)
);

CREATE TABLE expone (
	galeria INT,
	obra INT
);