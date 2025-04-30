-- Crear base de datos si no existe
DROP DATABASE IF EXISTS sistema_de_comida;
CREATE DATABASE sistema_de_comida;
USE sistema_de_comida;

-- Crear tabla Menu
CREATE TABLE Menu (
    idMenu INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(21),
    Cantidad INT,
    Precio DOUBLE,
    Descripcion VARCHAR(50)
);

CREATE TABLE Ticked (
    idTicked INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(21),
    Apellido VARCHAR(21),
    DNI INT,
    idMenu INT,
    PrecioTotal DOUBLE,
    Estado VARCHAR(21),
    Mesa BOOLEAN,
    FOREIGN KEY (idMenu) REFERENCES Menu(idMenu)
);

CREATE TABLE Pedido (
    idPedido INT PRIMARY KEY AUTO_INCREMENT,
    idMenu INT,
    Cantidad INT,
    Observacion VARCHAR(100),
    FOREIGN KEY (idMenu) REFERENCES Menu(idMenu)
);
