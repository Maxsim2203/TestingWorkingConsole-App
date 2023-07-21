# Задание 1
* Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

# Задание 2
* В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Диаграмма базы данных
![image](https://github.com/Hihiz/MindBoxTask/assets/98191494/be9c925b-24f0-4b42-b93e-c675dff6ac48)

### Скрипт базы данных 
```sql
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Спортивные товары')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Строй материалы')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [CategoryId]) VALUES (2, N'Футбольный мяч', 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId]) VALUES (3, N'Шланга', 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId]) VALUES (4, N'Гантеля', 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId]) VALUES (5, N'Грунтовка', 2)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId]) VALUES (6, N'Штукатурка', 2)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId]) VALUES (8, N'Отсев', 2)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
```
### Решение
```sql
select p.[Name] as Продукт, c.[Name] as Категория from Products as p
left join Categories as c on p.CategoryId = c.Id
order by p.[Name]
```
![image](https://github.com/Hihiz/MindBoxTask/assets/98191494/0d4308c9-6188-47fb-a0dc-45f589cc61df)
