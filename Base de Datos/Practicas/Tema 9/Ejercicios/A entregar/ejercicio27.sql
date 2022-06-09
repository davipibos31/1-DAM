CREATE DEFINER=`root`@`localhost` FUNCTION `ejercicio27`() RETURNS int
    DETERMINISTIC
BEGIN
	declare num_productos int;
    select avg(precio) into num_productos from productos;
    return num_productos;
END