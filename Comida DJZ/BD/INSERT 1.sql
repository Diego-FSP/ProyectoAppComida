-- Inserción de Menu
INSERT INTO Menu (Nombre, Cantidad, Precio, Descripcion)
VALUES 
('Empanadas', 30, 900.00, 'Carne cortada'),
('Pollo Broster', 10, 1800.00, 'Crujiente y jugoso'),
('Hamburguesa', 15, 1200.00, 'Clásica con queso'),
('Salchipapa', 20, 1000.00, 'Papas con salchichas'),
('Puré c/Milanesa', 12, 1700.00, 'Con salsa o sin salsa');

-- Inserción de ticket (usando idMenu = 3 que corresponde a 'Hamburguesa')
INSERT INTO Ticked (Nombre, Apellido, DNI, idMenu, PrecioTotal, Estado, Mesa)
VALUES ('Luis', 'Fernández', 45678912, 3, 900.00, 'Pagado', FALSE);

-- Inserciones de pedidos
INSERT INTO Pedido (idMenu, Cantidad, Observacion) VALUES
(1, 2, 'Sin picante'),
(2, 1, 'Extra crocante'),
(3, 3, 'Sin cebolla'),
(4, 1, 'Con mayonesa'),
(5, 2, 'Con salsa blanca');
