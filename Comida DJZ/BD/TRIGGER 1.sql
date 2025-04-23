DROP TRIGGER IF EXISTS restar_stock_ticked;

DELIMITER $$

CREATE TRIGGER restar_stock_ticked
AFTER INSERT ON Ticked
FOR EACH ROW
BEGIN
    -- Descontar stock de comida
    IF NEW.idComida IS NOT NULL THEN
        UPDATE Comida
        SET Cantidad = Cantidad - 1
        WHERE idComida = NEW.idComida;
    END IF;

    -- Descontar stock de bebida
    IF NEW.idBebidas IS NOT NULL THEN
        UPDATE Bebidas
        SET Cantidad = Cantidad - 1
        WHERE idBebidas = NEW.idBebidas;
    END IF;

    -- Descontar stock de postre
    IF NEW.idPostres IS NOT NULL THEN
        UPDATE Postres
        SET Cantidad = Cantidad - 1
        WHERE idPostres = NEW.idPostres;
    END IF;
END $$

DELIMITER ;
