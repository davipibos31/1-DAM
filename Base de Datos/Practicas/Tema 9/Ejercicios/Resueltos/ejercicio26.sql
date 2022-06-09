CREATE DEFINER=`root`@`localhost` FUNCTION `ejercicio26`() RETURNS int
    DETERMINISTIC
BEGIN
	declare num_productos int;
    select count(*) into num_productos from productos;
    return num_productos;
END