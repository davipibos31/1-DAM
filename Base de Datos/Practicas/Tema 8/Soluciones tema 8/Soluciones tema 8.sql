-- 1. Realiza el producto cartesiano entre la tabla municipio y la tabla provincia.
SELECT * FROM municipio, provincia;

-- 2. Añade a la sentencia del ejercicio anterior la condición WHERE necesaria para que
-- sólo se muestren las filas con los municipios y sus provincias correspondientes.
SELECT * FROM municipio, provincia WHERE municipio.provincia = provincia.codigo;

-- 3. Modifica la sentencia anterior para obtener únicamente el nombre del municipio y el
-- de la provincia a la que pertenece.
SELECT municipio.nombre as municipio, provincia.nombre as provincia 
    FROM municipio, provincia WHERE municipio.provincia = provincia.codigo;


-- 4. Modifica la sentencia anterior para obtener únicamente las filas de aquellos
-- municipios que empiezan por B.
SELECT municipio.nombre as municipio, provincia.nombre as provincia 
    FROM municipio, provincia 
    WHERE municipio.provincia = provincia.codigo AND municipio.nombre LIKE "B%";

-- 5. Realiza el producto cartesiano entre la tabla cliente y municipio.
SELECT * FROM cliente, municipio;

-- 6. Añade a la sentencia del ejercicio anterior la condición WHERE necesaria para que
-- sólo se muestren las filas con los clientes y el municipio al que pertenecen.
SELECT * FROM cliente, municipio WHERE cliente.municipio = municipio.codigo;


-- 7. Modifica la sentencia anterior para obtener el número de clientes de cada municipio.
SELECT municipio.nombre, COUNT(cliente.codigo) 
    FROM cliente, municipio WHERE cliente.municipio = municipio.codigo GROUP BY municipio.nombre;

-- 8. Escribe una sentencia que muestre el código de ticket, la fecha y el nombre del cliente.
-- Utiliza la sintaxis SQL 92 y SQL 99.
-- SQL 92
SELECT ticket.codigo, fecha, cliente.nombre 
    FROM cliente, ticket WHERE cliente.codigo = ticket.cliente;
-- SQL 99
SELECT ticket.codigo, fecha, cliente.nombre 
    FROM cliente INNER JOIN ticket ON ticket.cliente = cliente.codigo;

-- 9. Escribe una sentencia que muestre el código de ticket, el número de línea, la
-- descripción del artículo y la cantidad de unidades vendidas en dicha línea para todas
-- las líneas del ticket con código 7. Utiliza la sintaxis SQL 92 y SQL 99.
-- SQL 92
SELECT lt.ticket, art.descripcion, lt.cant 
    FROM linea_ticket as lt, articulo as art WHERE lt.articulo = art.codigo AND lt.ticket = 7;
-- SQL 99
SELECT lt.ticket, art.descripcion, lt.cant 
    FROM linea_ticket as lt 
    INNER JOIN articulo as art 
        ON lt.articulo = art.codigo
    WHERE lt.ticket = 7;

-- 10. Escribe una sentencia que muestre el código y fecha de cada ticket junto al nombre
-- del cliente y el nombre del vendedor. Utiliza la sintaxis SQL 92 y SQL 99.
-- SQL 92
SELECT t.codigo, t.fecha, c.nombre as cliente, v.nombre as vendedor
    FROM ticket as t, cliente as c, vendedor as v
    WHERE t.cliente = c.codigo AND t.vendedor = v.codigo;

-- SQL 99
SELECT t.codigo, t.fecha, c.nombre as cliente, v.nombre as vendedor
    FROM ticket as t 
    JOIN cliente as c ON t.cliente = c.codigo 
    JOIN vendedor as v ON t.vendedor = v.codigo;

-- 11. Escribe una sentencia que muestre el código y nombre de cada vendedor junto al
-- número total de tickets en los que aparece. Utiliza la sintaxis SQL 92 y SQL 99.
-- SQL 92
SELECT v.codigo, v.nombre, COUNT(t.vendedor) as tickets
    FROM ticket as t, vendedor as v WHERE t.vendedor = v.codigo GROUP BY v.codigo;
-- SQL 99
SELECT v.codigo, v.nombre, COUNT(t.vendedor) as tickets
    FROM ticket as t
    JOIN vendedor as v ON t.vendedor = v.codigo GROUP BY v.codigo;


-- 12. Escribe una sentencia que muestre el código y fecha de cada ticket, junto al nombre y
-- dirección completa (calle, código postal, municipio y provincia) del cliente. Utiliza la
-- sintaxis SQL 92 y SQL 99.
-- SQL 92
SELECT t.codigo, t.fecha, c.nombre, 
       c.direccion, c.cp, m.nombre as municipio, p.nombre as provincia
    FROM ticket as t, cliente as c, municipio as m, provincia as p
    WHERE t.cliente = c.codigo AND c.municipio = m.codigo AND m.provincia = p.codigo;

-- SQL 99
SELECT t.codigo, t.fecha, c.nombre, 
       c.direccion, c.cp, m.nombre as municipio, p.nombre as provincia
    FROM ticket as t
    JOIN cliente as c ON t.cliente = c.codigo
    JOIN municipio as m ON c.municipio = m.codigo
    JOIN provincia as p ON m.provincia = p.codigo;

-- 13. Mostrar el código de ticket, fecha y nombre del cliente sin que se pierda ningún ticket,
-- aunque su cliente sea NULL.
SELECT t.codigo, t.fecha, c.nombre 
    FROM ticket as t 
    LEFT JOIN cliente as c
    ON t.cliente = c.codigo;

-- 14. Mostrar el nombre y dirección de los clientes junto con el nombre de su municipio sin
-- perder aquellos municipios que no tienen clientes.
SELECT c.nombre, c.direccion, m.nombre
    FROM cliente as c
    RIGHT JOIN municipio as m
    ON c.municipio = m.codigo;

-- 15. Escribe una consulta que devuelva el código de ticket, línea, código y descripción del
-- artículo para todas las líneas del ticket 108, aunque el código de artículo sea nulo.
SELECT lt.ticket, lt.nlinea, art.codigo, art.descripcion 
    FROM linea_ticket as lt
    LEFT JOIN articulo as art
    ON lt.articulo = art.codigo 
    WHERE lt.ticket = 108;

-- 16. Si has resuelto la sentencia anterior con RIGHT JOIN, resuélvela con LEFT JOIN. Si
-- la has resuelto con LEFT JOIN, resuélvela con RIGHT JOIN.
SELECT lt.ticket, lt.nlinea, art.codigo, art.descripcion 
    FROM articulo as art
    RIGHT JOIN linea_ticket as lt
    ON lt.articulo = art.codigo
    WHERE lt.ticket = 108;

-- 17. Mostrar el nombre de cada municipio y el número de clientes residiendo en cada uno
-- de ellos. Los municipios que no tienen ningún cliente no aparecerán.
SELECT m.nombre, COUNT(c.codigo) as num_clientes
    FROM municipio as m
    JOIN cliente as c
    ON c.municipio = m.codigo
    GROUP BY m.nombre;

-- 18. Mostrar el nombre de cada municipio y el número de clientes residiendo en cada uno
-- de ellos. Los municipios que no tienen ningún cliente también aparecerán.
SELECT m.nombre, COUNT(c.codigo) as num_clientes
    FROM municipio as m
    LEFT JOIN cliente as c
    ON c.municipio = m.codigo
    GROUP BY m.nombre;

-- 19. Escribe una consulta que devuelva el código y fecha de cada ticket junto al nombre del
-- vendedor que realizó la venta y el nombre del cliente destinatario del ticket. No se
-- debe perder ningún ticket aunque no tenga código de vendedor o código de cliente.
SELECT t.codigo, t.fecha, v.nombre, c.nombre
    FROM ticket as t
    LEFT JOIN vendedor as v
    ON t.vendedor = v.codigo
    LEFT JOIN cliente as c
    ON t.cliente = c.codigo;

-- 20. Obtén el nombre de los clientes y el número de tickets en los que aparece cada uno.
-- También se mostrará el nombre de los clientes que no aparecen en ningún ticket.
SELECT c.nombre, COUNT(t.codigo)
    FROM cliente as c
    LEFT JOIN ticket as t
    ON c.codigo = t.cliente
    GROUP BY c.codigo;

-- 21. Escribe una sentencia que muestre el código y nombre de cada vendedor y el total de
-- ventas (importe total de sus tickets ignorando posibles descuentos e impuestos).
SELECT v.codigo, v.nombre, SUM(lt.cant * lt.precio) as total_ventas
    FROM linea_ticket as lt
    JOIN ticket as t
    ON lt.ticket = t.codigo
    JOIN vendedor as v
    ON t.vendedor = v.codigo
    GROUP BY t.vendedor;

-- 22. Escribe una sentencia que muestre el nombre de la provincia y la cantidad total de
-- artículos vendidos a clientes que residen en dicha provincia.
SELECT p.nombre, SUM(lt.cant) as cant_vendidos
    FROM linea_ticket as lt
    JOIN ticket as t
    ON lt.ticket = t.codigo
    JOIN cliente as c
    ON c.codigo = t.cliente
    JOIN municipio as m
    ON m.codigo = c.municipio
    JOIN provincia as p
    ON p.codigo = m.provincia
    GROUP BY p.codigo;

-- 23. Escribe una consulta que muestre el código y nombre de aquellos clientes de la
-- provincia de Castellón (con có digo de provincia ‘CA’) que en total han gastado más de
-- 100 euros (ignora descuentos e impuestos).
SELECT c.codigo, c.nombre
    FROM linea_ticket as lt
    JOIN ticket as t
    ON lt.ticket = t.codigo
    JOIN cliente as c
    ON c.codigo = t.cliente 
    JOIN municipio as m
    ON m.codigo = c.municipio AND m.provincia = "CA"
    GROUP BY c.codigo
    HAVING SUM(lt.cant * lt.precio) > 100;

-- 24. Escribe una consulta que obtenga el nombre de cada vendedor y el de su jefe.
SELECT v.nombre, j.nombre as jefe
    FROM vendedor as v
    JOIN vendedor as j
    WHERE v.jefe = j.codigo;

-- 25. Obtén el nombre de cada asignatura, así como el curso, edificio y aula donde se
-- imparte.
SELECT a.nombre, a.curso, i.edificioAula as edificop, i.claseAula as aula
    FROM asignatura as a
    JOIN imparte as i
    ON a.codigo = i.asignatura;

-- 26. Obtén el nombre completo de cada profesor junto con el nombre y curso de cada una
-- de las asignaturas asignatura que imparte.
SELECT CONCAT_WS(' ', p.nombre, p.apellido1, p.apellido2) as profesor, a.nombre, a.curso
    FROM ensenya as e
    JOIN profesor as p
    ON e.profesor = p.DNI
    JOIN asignatura as a
    ON e.asignatura = a.codigo;

-- 27. Obtén el nombre y apellidos de los alumnos nacidos en 1999 junto con el nombre de
-- cada una de las asignaturas que cursa y la nota obtenida.
SELECT al.nombre, al.apellido1, al.apellido2, a.nombre as asignatura, m.nota
    FROM matricula as m
    JOIN alumno as al
    ON m.alumno = al.DNI
    JOIN asignatura as a
    ON m.asignatura = a.codigo;

-- 28. Obtén el nombre de los profesores y el número de alumnos que tienen.
SELECT p.nombre, count(m.alumno) as num_alumnos
    FROM profesor as p
    JOIN ensenya as e
    ON p.DNI = e.profesor
    JOIN asignatura as a
    ON e.asignatura = a.codigo
    JOIN matricula as m
    ON m.asignatura = a.codigo
    JOIN reparto as r
    ON r.alumno = m.alumno AND
        r.grupo = e.grupo
    GROUP BY p.DNI;


-- 29. Para cada asignatura, obtén el nombre, el curso y la nota media obtenida por los
-- alumnos que la cursan.
SELECT a.nombre, a.curso, AVG(m.nota) as nota_media
    FROM asignatura as a
    JOIN matricula as m
    ON m.asignatura = a.codigo
    GROUP BY m.asignatura;

-- 30. Obtén el nombre completo de cada alumno y la cantidad de asignaturas en que está
-- matriculado cada uno de ellos siempre y cuando esté matriculado en menos de 5
-- asignaturas

SELECT CONCAT_WS(' ', al.nombre, al.apellido1, al.apellido2) as alumno, 
       COUNT(m.asignatura) as num_asignaturas
    FROM alumno as al
    JOIN matricula as m
    ON m.alumno = al.DNI
    GROUP BY al.DNI HAVING COUNT(m.asignatura) < 5;