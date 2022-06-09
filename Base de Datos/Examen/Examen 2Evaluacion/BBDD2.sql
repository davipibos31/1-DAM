CREATE TABLE departamentos (
  codigo INTEGER PRIMARY KEY,
  nombre varchar(255) NOT NULL ,
  gastos decimal NOT NULL 
);

CREATE TABLE empleados (
  codigo INTEGER PRIMARY KEY,
  nombre varchar(255) NOT NULL ,
  apellido varchar(255) NOT NULL ,
  departamento INTEGER NOT NULL , 
  foreign key (departamento) references departamentos(codigo) 
);

INSERT INTO departamentos(codigo,nombre,gastos) VALUES(14,'IT',65000);
INSERT INTO departamentos(codigo,nombre,gastos) VALUES(37,'Accounting',15000);
INSERT INTO departamentos(codigo,nombre,gastos) VALUES(59,'Human Resources',240000);
INSERT INTO departamentos(codigo,nombre,gastos) VALUES(77,'Research',55000);

INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('123234877','Michael','Rogers',14);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('152934485','Anand','Manikutty',14);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('222364883','Carol','Smith',37);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('326587417','Joe','Stevens',37);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('332154719','Mary-Anne','Foster',14);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('332569843','George','ODonnell',77);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('546523478','John','Doe',59);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('631231482','David','Smith',77);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('654873219','Zacary','Efron',59);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('745685214','Eric','Goldsmith',59);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('845657245','Elizabeth','Doe',14);
INSERT INTO empleados(codigo,nombre,apellido,departamento) VALUES('845657246','Kumar','Swamy',14);
