select * from empleado, departamento;
select * from empleado, departamento where departamento = id;
select * from empleado, departamento where departamento = departamento.id;
select e.nombre, d.nombre from empleado as e, departamento as d where departamento = d.id;
select * from empleado natural join reserva;
select * from empleado as e, reserva as r where e.id = r.id;
select emp.nombre as empleado , dep.nombre as departamento from empleado as emp inner join departamento as dep on emp.departamento = dep.id;