CREATE DEFINER=`root`@`localhost` FUNCTION `ejercicio28`() RETURNS int
    DETERMINISTIC
BEGIN
	declare num_productos int;
    select min(precio) into num_productos from productos;
    return num_productos;
END