-- Inserción de comidas
INSERT INTO Comida (idComida, Nombre, Cantidad, Precio, Descripcion)
VALUES 
(1, 'Empanadas', 30, 900.00, 'Carne cortada'),
(2, 'Pollo Broster', 10, 1800.00, 'Crujiente y jugoso'),
(3, 'Hamburguesa', 15, 1200.00, 'Clásica con queso'),
(4, 'Salchipapa', 20, 1000.00, 'Papas con salchichas'),
(5, 'Puré c/Milanesa', 12, 1700.00, 'Con salsa o sin salsa');

-- Inserción de bebidas (comienza desde idBebidas = 6)
INSERT INTO Bebidas (idBebidas, Nombre, Cantidad, Precio, Descripcion)
VALUES 
(6, 'Coca-Cola', 30, 500.00, 'Bebida fría'),
(7, 'Pepsi', 25, 500.00, 'Con gas'),
(8, 'Jugo de Naranja', 20, 600.00, 'Natural'),
(9, 'Agua Mineral', 50, 300.00, 'Sin gas'),
(10, 'Fanta', 20, 500.00, 'Sabor naranja');

-- Inserción de postres (comienza desde idPostres = 11)
INSERT INTO Postres (idPostres, Nombre, Cantidad, Precio, Descripcion)
VALUES 
(11, 'Flan', 15, 700.00, 'Con dulce de leche'),
(12, 'Helado', 20, 900.00, 'Varios sabores'),
(13, 'Tiramisú', 10, 1200.00, 'Postre italiano'),
(14, 'Tarta de Manzana', 8, 1000.00, 'Casera'),
(15, 'Cheesecake', 12, 1100.00, 'Con frutilla'),
(16, 'Brownie', 14, 950.00, 'Con nueces'),
(17, 'Panqueques', 10, 850.00, 'Con dulce de leche'),
(18, 'Gelatina', 18, 600.00, 'Sabor frutal'),
(19, 'Ensalada de Frutas', 12, 1000.00, 'Fresca y natural'),
(20, 'Budín de Pan', 9, 950.00, 'Clásico casero');

-- Inserción de ticket (usando idComida = 3 que está disponible)
INSERT INTO Ticked (idTicked, Nombre, Apellido, DNI, idComida, PrecioTotal, Estado, Mesa)
VALUES (1, 'Luis', 'Fernández', 45678912, 3, 900.00, 'Pagado', FALSE);

-- Inserción de calificación para la comida con idComida = 3
INSERT INTO calificacion (idComida, Valor, Cliente)
VALUES (3, 5, 'Luis Fernández');
