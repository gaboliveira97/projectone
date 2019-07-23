--1) 
select Nome from Marcas where UsuInc =1

--2)
select Nome from Marcas where UsuInc =2

--3)
SELECT COUNT (Nome) AS 'Quantidade de marcas'
FROM Marcas 
WHERE UsuInc = 1
    ORDER BY 'Quantidade de carros' DESC

--4)
SELECT COUNT (Nome) AS 'Quantidade de marcas'
FROM Marcas 
WHERE UsuInc = 2
    ORDER BY 'Quantidade de carros' DESC

--5)
SELECT COUNT(Nome) AS 'Quantidade de carros'
from Marcas


--6)
select Modelo from Carros where UsuInc =1

--7)
select Modelo from Carros where UsuInc =2

--8)
SELECT COUNT (Modelo) AS 'Quantidade de carros'
FROM Carros 
WHERE UsuInc = 1
    ORDER BY 'Quantidade de carros' DESC

--9)
SELECT COUNT (Modelo) AS 'Quantidade de carros'
FROM Carros 
WHERE UsuInc = 2
    ORDER BY 'Quantidade de carros' DESC

--10)
SELECT COUNT(Modelo) AS 'Quantidade de carros'
from Carros

--11)
SELECT c.Modelo
from Carros as c
inner join Marcas as m on c.Marca = m.Id
WHERE c.UsuInc = 1

--12)
SELECT c.Modelo
from Carros as c
inner join Marcas as m on c.Marca = m.Id
WHERE c.UsuInc = 2

--13)
SELECT COUNT (c.Modelo) AS 'Quantidade de Carros'
from Carros as c
inner join Marcas as m on c.Marca = m.Id
WHERE c.UsuInc = 2