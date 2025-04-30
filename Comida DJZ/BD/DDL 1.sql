DROP DATABASE IF EXISTS sistema_comida;
CREATE DATABASE sistema_comida;
USE sistema_comida;

-- Tabla: Comida
CREATE TABLE Comida (
    idComida INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(21),
    Cantidad INT,
    Precio DOUBLE,
    Descripcion VARCHAR(21)
);

-- Tabla: Ticked
CREATE TABLE Ticked (
    idTicked INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(21),
    Apellido VARCHAR(21),
    DNI INT,
    idComida INT,
    PrecioTotal DOUBLE,
    Estado VARCHAR(21),
    Mesa BOOLEAN,
    FOREIGN KEY (idComida) REFERENCES Comida(idComida)
);

-- Tabla: Calificacion
CREATE TABLE Calificacion (
    idCalificacion INT PRIMARY KEY AUTO_INCREMENT,
    idComida INT,
    Valor INT,
    Cliente VARCHAR(21),
    FOREIGN KEY (idComida) REFERENCES Comida(idComida)
);
