USE [Inventario]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 2/13/2025 8:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[ID] [int] NOT NULL,
	[fecha] [date] NULL,
	[cliente] [varchar](50) NULL,
	[ID_Producto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 2/13/2025 8:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [text] NULL,
	[precio] [decimal](10, 2) NULL,
	[cantidad] [int] NULL,
	[categoria] [varchar](30) NULL,
	[ID_Proveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 2/13/2025 8:30:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [text] NULL,
	[telefono] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (1, CAST(N'2025-01-17' AS Date), N'Carlos Rojas', 5)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (2, CAST(N'2025-01-17' AS Date), N'Patrick Solano', 1)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (3, CAST(N'2025-01-19' AS Date), N'Rosa Perez', 5)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (4, CAST(N'2025-01-21' AS Date), N'Juan Martinez', 2)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (5, CAST(N'2025-01-27' AS Date), N'Daniel Molina', 1)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (6, CAST(N'2025-01-24' AS Date), N'Michael Arrieta', 5)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (7, CAST(N'2025-01-22' AS Date), N'Maria Mora', 15)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (8, CAST(N'2025-01-16' AS Date), N'Carla Lopez', 9)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (9, CAST(N'2025-01-22' AS Date), N'Julio Castillo', 1)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (10, CAST(N'2025-01-21' AS Date), N'Tomas Mendez', 4)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (11, CAST(N'2025-01-26' AS Date), N'David Brenes', 7)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (12, CAST(N'2025-01-25' AS Date), N'Bianca Aguilar', 4)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (13, CAST(N'2025-01-24' AS Date), N'Fiorella Madriz', 11)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (14, CAST(N'2025-01-23' AS Date), N'Sara Cedeno', 5)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (15, CAST(N'2025-01-22' AS Date), N'Tatiana Otarola', 13)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (16, CAST(N'2025-02-05' AS Date), N'Alexander Curling', 2)
INSERT [dbo].[Pedidos] ([ID], [fecha], [cliente], [ID_Producto]) VALUES (17, CAST(N'2025-02-12' AS Date), N'Brandon Barrantes', 5)
GO
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (1, N'Reloj', N'Reloj de mano para hombre', CAST(25.00 AS Decimal(10, 2)), 21, N'Accesorios', 1)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (2, N'Laptop', N'Laptop Portatil', CAST(250.00 AS Decimal(10, 2)), 10, N'Electrónica', 11)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (3, N'Telefono', N'Iphone', CAST(550.00 AS Decimal(10, 2)), 10, N'Electrónica', 1)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (4, N'Brazalete', N'Brazalete de Mujer', CAST(10.00 AS Decimal(10, 2)), 100, N'Accesorios', 12)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (5, N'Microondas', N'Microondas pequeño', CAST(350.00 AS Decimal(10, 2)), 5, N'Electrodomesticos', 2)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (6, N'Audifonos', N'Headset wireless', CAST(50.00 AS Decimal(10, 2)), 15, N'Electrónica', 5)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (7, N'Bufanda', N'Bufanda de Tela', CAST(5.50 AS Decimal(10, 2)), 12, N'Accesorios', 13)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (8, N'Monitor', N'24 pulgadas', CAST(270.00 AS Decimal(10, 2)), 3, N'Electrónica', 2)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (9, N'Monitor', N'36 pulgadas', CAST(380.00 AS Decimal(10, 2)), 8, N'Electrónica', 2)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (10, N'Mouse', N'Wireless', CAST(12.00 AS Decimal(10, 2)), 6, N'Electrónica', 9)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (11, N'Refrigerador', N'Refrigerador grande', CAST(1.25 AS Decimal(10, 2)), 4, N'Electrodomesticos', 14)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (12, N'Cocina', N'Cocina de Gas', CAST(7150.00 AS Decimal(10, 2)), 4, N'Electrodomesticos', 14)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (13, N'Telefono', N'Samsung', CAST(450.00 AS Decimal(10, 2)), 10, N'Electrónica', 3)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (14, N'Telefono', N'Huawei', CAST(500.00 AS Decimal(10, 2)), 16, N'Electrónica', 15)
INSERT [dbo].[Productos] ([ID], [nombre], [descripcion], [precio], [cantidad], [categoria], [ID_Proveedor]) VALUES (15, N'Lentes', N'Lentes de sol', CAST(25.00 AS Decimal(10, 2)), 22, N'Accesorio', 6)
GO
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (1, N'Apple', N'Alajuela', N'24402536')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (2, N'Sony', N'Alajuela', N'24402536')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (3, N'Samsung', N'San Jose', N'24402558')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (4, N'Epson', N'Heredia', N'24402266')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (5, N'Huewei', N'Alajuela', N'24402976')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (6, N'Ekono', N'Heredia', N'22502536')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (7, N'AOC', N'San Jose', N'24436538')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (8, N'DELL', N'Cartago', N'22602531')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (9, N'MSI', N'Alajuela', N'24402597')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (10, N'FRIDGIDARE', N'Heredia', N'24402456')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (11, N'HP', N'Cartago', N'24413436')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (12, N'El REY', N'Alajuela', N'24402413')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (13, N'Pequeño Mundo', N'Puntarenas', N'24402856')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (14, N'Gollo', N'Alajuela', N'24402366')
INSERT [dbo].[Proveedores] ([ID], [nombre], [direccion], [telefono]) VALUES (15, N'Monge', N'San Jose', N'24413636')
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedores]
GO
