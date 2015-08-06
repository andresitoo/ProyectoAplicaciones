CREATE TABLE [dbo].[IN_M_PRODUCTO](
	[Codigo_Producto] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion_Producto] [varchar](20) NOT NULL,
	[Tipo_Producto] [varchar](30) NOT NULL,
	[Medida] [varchar](30) NOT NULL,
	[Bodega] [varchar](30) NOT NULL,
	[Percha] [varchar](30) NOT NULL,
	[Existencia_Actual] [numeric](3, 0) NOT NULL,
	[Stock_Minimo] [numeric](3, 0) NOT NULL,
	[Stock_Maximo] [numeric](3, 0) NOT NULL,
	[Costo] [numeric](4, 2) NOT NULL,
	[Precio] [numeric](4, 2) NOT NULL,
	[Estado] [char](1) NOT NULL,
 CONSTRAINT [PK_SAV_M_Producto] PRIMARY KEY CLUSTERED 
(
	[Codigo_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[IN_R_TIPO_DOCUMENTO](
	[Codigo_TipoDocumento] [numeric](4, 0) NOT NULL,
	[Descripcion_TipoDocumento] [varchar](40) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[IN_R_TIPO_MEDIDA](
	[Codigo_Medida] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion_Medida] [varchar](20) NOT NULL,
	[Estado] [char](1) NOT NULL,
 CONSTRAINT [PK_SAV_M_TipoUnidad] PRIMARY KEY CLUSTERED 
(
	[Codigo_Medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[IN_M_BODEGA](
	[Codigo_Bodega] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion_Bodega] [varchar](40) NOT NULL,
	[Direccion_Bodega] [varchar](40) NOT NULL,
	[Cantidad_Percha] [varchar](40) NOT NULL,
	[Responsable] [varchar](30) NOT NULL,
	[Estado] [char](1) NOT NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[Codigo_Bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[IN_M_PERCHA](
	[Codigo_Percha] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion_Percha] [varchar](30) NOT NULL,
	[UbicacionPercha] [varchar](30) NOT NULL,
	[Cantidad_NivelesPercha] [varchar](10) NOT NULL,
	[Estado] [char](1) NOT NULL,
 CONSTRAINT [PK_Percha] PRIMARY KEY CLUSTERED 
(
	[Codigo_Percha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

--------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[IN_M_MOVIMIENTO_INVENTARIO](
	[CodigoMov_Inventario] [numeric](4, 0) NOT NULL,
	[TipoDocumento] [varchar](30) NOT NULL,
	[DescripcionMov_Inventario] [varchar](30) NOT NULL,
	[AsociadoA] [varchar](15) NOT NULL,
	[Estado] [char](1) NOT NULL,
 CONSTRAINT [PK_IN_M_MOVIMIENTO_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[CodigoMov_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[IN_M_MOVIMIENTO_INVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_IN_M_MOVIMIENTO_INVENTARIO_IN_M_MOVIMIENTO_INVENTARIO] FOREIGN KEY([CodigoMov_Inventario])
REFERENCES [dbo].[IN_M_MOVIMIENTO_INVENTARIO] ([CodigoMov_Inventario])
GO

ALTER TABLE [dbo].[IN_M_MOVIMIENTO_INVENTARIO] CHECK CONSTRAINT [FK_IN_M_MOVIMIENTO_INVENTARIO_IN_M_MOVIMIENTO_INVENTARIO]
GO

---------------------------------------------------------------------------------------------------

