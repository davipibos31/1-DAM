CREATE DEFINER=`root`@`localhost` PROCEDURE `ejercicio15`(in num int) 
BEGIN
declare signo varchar(20);
	if (num > 0) then
		set signo := 'Positivo';
	elseif (num < 0) then
		set signo := 'Negativo';
	else
		set signo := 'Cero';
	end if;
        select signo;
END