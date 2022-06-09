CREATE DEFINER=`root`@`localhost` FUNCTION `ejercicio23`(num real) RETURNS double
    DETERMINISTIC
BEGIN
	declare res real;
    set res := sqrt(num);
    if res is null then
		set res := -1;
	end if;
RETURN res;
END