# First task

*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

 *- Юнит-тесты*
 
 *- Легкость добавления других фигур*
 
 *- Вычисление площади фигуры без знания типа фигуры*
 
 *- Проверку на то, является ли треугольник прямоугольным"*
 
### Solve task:
 
 [Library](https://github.com/BioMihanoid/TestTaskForMindbox/tree/master/FiguresLibrary)
 
 [Unit tests](https://github.com/BioMihanoid/TestTaskForMindbox/tree/master/UnitTestFiguresLibrary)
 
# Second task:
 
 *В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
 Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*
 
### Solve task:
  
```
SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductsCategories pc
	ON p.Id = pc.ProductId
LEFT JOIN Categories c
	ON pc.CategoryId = c.Id;
ORDER BY p.Name;
```

