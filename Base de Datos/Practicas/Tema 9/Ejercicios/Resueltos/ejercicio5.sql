CREATE DEFINER=`root`@`localhost` PROCEDURE `ejercicio 5`()
BEGIN
declare i integer;
declare j integer;
declare suma integer;
set i = 0;
set j = 10;
set suma = 0;
loop1 : while i <= j do
set suma = suma + i;
set i := i + 1;
end while loop1;
select suma;
END