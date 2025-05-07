-- Crear base de datos si no existe
DROP DATABASE IF EXISTS sistema_de_comida;
CREATE DATABASE sistema_de_comida;
USE sistema_de_comida;

-- Crear tabla TipoM
CREATE TABLE TipoM (
    IDTipoM INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(21) NOT NULL
);

-- Actualizar tabla Menu si aún no tiene la FK (en caso de que no lo hayas hecho ya)
CREATE TABLE Menu (
    idMenu INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(21) NOT NULL,
    Cantidad INT NOT NULL,
    Precio DOUBLE NOT NULL,
    Descripcion VARCHAR(255),
    IDTipo INT,
    FOREIGN KEY (IDTipo) REFERENCES TipoM(IDTipoM)
);

CREATE TABLE Pedido (
    idPedido INT PRIMARY KEY AUTO_INCREMENT,
    PrecioTotal DOUBLE,
    idMenu INT,
    cantidad INT,
    FOREIGN KEY (idMenu) REFERENCES Menu(idMenu)
);

CREATE TABLE Ticked (
    idTicked INT PRIMARY KEY AUTO_INCREMENT,
    idPedido INT,
    Nombre VARCHAR(21),
    mesa BOOLEAN,
    hora DATETIME,
    FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido)
);

