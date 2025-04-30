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
END $$

DELIMITER ;
