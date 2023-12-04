Utilizando la base de datos anterior (tablas CENTROS, DEPARTAMENTOS y EMPLEADOS), realizar las siguientes consultas:

1.	Hallar la comisión, el nombre y el salario de los empleados con más de tres hijos, ordenados por comisión y, dentro de comisión, alfabéticamente.

```sql
SELECT e.comision, e.nombre, e.salario, e.numhijos
FROM empleados e
WHERE e.numhijos >= 3
ORDER BY comision ASC;
```

2.	Obtener los nombres de los departamentos que no dependen de otros.
   
```sql
SELECT d.nombre
FROM departamentos d
WHERE d.depto_jefe=0;
```

3.	Obtener, por orden alfabético, los nombres y los salarios de los empleados cuyo salario esté comprendido entre 1250 y 1300 euros.

```sql
SELECT e.nombre, e.salario
FROM empleados e
WHERE e.salario>=1250 AND e.salario<=1300
ORDER BY e.nombre ASC;
```

4.	Datos de los empleados que cumplen la condición anterior o tienen al menos un hijo.

```sql
SELECT e.nombre, e.salario
FROM empleados e
WHERE e.salario>=1250 AND e.salario<=1300 AND e.numhijos<=1
ORDER BY e.nombre ASC;
```

5.	Muestre para cada empleado el número de meses que lleva el empleado en la empresa junto con su nombre.

```sql
SELECT e.nombre, (datediff(CURRENT_DATE, e.fecha)/30)
FROM empleados e;
```

6.	Calcule aquellos empleados que llevan más de 35 años en la empresa. Muestre todos los datos de cada uno de ellos.

```sql
SELECT e.*
FROM empleados e
WHERE (datediff(CURRENT_DATE, e.fecha)/365)>=35;
```

7.	Hallar, por orden alfabético, los nombres de los empleados tales que si se les da una gratificación de 10 euros por hijo, el total de esta gratificación no supera la centésima parte del salario.

```sql

```

8.	Hallar, por orden de número de empleado, el nombre y el salario total (salario más comisión) de los empleados cuyo salario total supera los 1300 euros mensuales.

```sql
SELECT e.cod, e.nombre, (e.salario+e.comision)
FROM empleados e 
WHERE (e.salario+e.comision)>=1300
ORDER BY e.cod ASC;
```

9.	Obtener, por orden alfabético, los nombres de los departamentos que no contengan la palabra 'Dirección' ni 'Sector'.

```sql
SELECT d.nombre
FROM departamentos d
WHERE d.nombre NOT LIKE '%Dirección%' AND d.nombre NOT LIKE '%Sector%'
ORDER BY d.nombre ASC;
```

10.	Obtener, por orden alfabético, los nombres de los departamentos que, o bien tienen directores en funciones y su presupuesto no excede los 5 mil euros, o bien no dependen de ningún otro departamento.

```sql
```
