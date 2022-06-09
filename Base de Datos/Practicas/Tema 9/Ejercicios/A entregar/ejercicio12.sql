Drop trigger if exists productos_BI_trigger2;
DELIMITER //
CREATE DEFINER=CURRENT_USER TRIGGER productos_BI_trigger2 before UPDATE ON productos FOR EACH ROW
BEGIN
 -- Instrucciones asociadas al trigger
 IF (new.precio < 0) THEN
	SET new.precio := 0;
 END IF;
END//
DELIMITER ;