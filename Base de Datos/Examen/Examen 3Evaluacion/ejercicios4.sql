CREATE FUNCTION `new_function` (precio_min decimal(10,2), precio_max decimal(10,2)) 
RETURNS INTEGER
deterministic
BEGIN
	if (new.precio > precio_min && new.precio < precio_max) then
		select count(*) from productos;
    end if;
RETURN 1;
END