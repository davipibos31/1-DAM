CREATE DEFINER=`root`@`localhost` PROCEDURE `ejercicio 6`()
BEGIN
declare i integer;
declare j integer;
declare suma integer;

set i = 0;
set j = 10;
set suma = 0;

repeat
set suma = suma + i;
set i := i + 1; 
until (i <j)
end repeat;
END