USE [SAV]
GO
/****** Object:  Schema [Compras]    Script Date: 03/08/2015 13:29:47 ******/
CREATE SCHEMA [Compras]
GO
/****** Object:  Table [Compras].[OrdenCompraDet]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Compras].[OrdenCompraDet](
	[Numero] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[Linea] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero] ASC,
	[IdEmpresa] ASC,
	[Linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_CABECERA_COTIZACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_CABECERA_COTIZACION](
	[numero] [numeric](4, 0) NOT NULL,
	[id_provedor] [numeric](4, 0) NULL,
	[id_user_aprovacion] [numeric](4, 0) NULL,
	[fecha] [date] NULL,
	[cod_estado] [numeric](4, 0) NULL,
	[num_pedido] [numeric](4, 0) NULL,
	[subtotal] [numeric](4, 2) NULL,
	[iva] [numeric](4, 2) NULL,
	[total] [numeric](4, 2) NULL,
 CONSTRAINT [PK_CP_CABECERA_COTIZACION] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_CABECERA_DESPACHO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_CABECERA_DESPACHO](
	[numero] [numeric](4, 0) NOT NULL,
	[fecha_despacho] [date] NULL,
	[fecha_entrega] [date] NULL,
	[numero_orden_compra] [numeric](4, 0) NULL,
	[id_proveedor] [numeric](4, 0) NULL,
	[id_estado] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CP_CABECERA_DESPACHO] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_CABECERA_PEDIDO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CP_CABECERA_PEDIDO](
	[numero] [numeric](4, 0) NOT NULL,
	[responsable] [varchar](30) NULL,
	[fecha] [date] NULL,
	[Observaciones] [varchar](50) NULL,
 CONSTRAINT [PK_CP_CABECERA_PEDIDO] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CP_DETALLE_COTIZACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_DETALLE_COTIZACION](
	[numero] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[cantidad] [numeric](4, 0) NULL,
	[id_producto] [numeric](4, 0) NULL,
	[costo_unitario] [numeric](4, 2) NULL,
	[subtotal_linea] [numeric](4, 2) NULL,
 CONSTRAINT [PK_CP_DETALLE_COTIZACION] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_DETALLE_DESPACHO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_DETALLE_DESPACHO](
	[numero] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) NOT NULL,
	[cantidad] [numeric](4, 0) NULL,
	[id_producto] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CP_DETALLE_DESPACHO] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_DETALLE_PEDIDO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_DETALLE_PEDIDO](
	[numero] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[cantidad] [numeric](4, 0) NULL,
	[id_producto] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CP_DETALLE_PEDIDO] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_ESTADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CP_ESTADO](
	[codigo] [numeric](4, 0) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CP_ESTADO_1] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CP_M_PROVEEDOR]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CP_M_PROVEEDOR](
	[Codigo_Proveedor] [numeric](4, 0) NOT NULL,
	[nombre] [varchar](50) NULL,
	[razonSocial] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[fecha_ingreso] [date] NULL,
	[responsable_legal] [varchar](50) NULL,
	[contabilidad] [bit] NULL,
	[ruc] [varchar](13) NULL,
	[cedula_pass] [varchar](10) NULL,
	[id_tipo_producto] [numeric](4, 0) NULL,
	[dias_despacho] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CP_M_PROVEEDOR] PRIMARY KEY CLUSTERED 
(
	[Codigo_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CP_ORDEN_COMPRA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_ORDEN_COMPRA](
	[numero] [numeric](4, 0) NOT NULL,
	[fecha_generacion] [date] NULL,
	[fecha_entrega] [date] NULL,
	[id_responsable] [numeric](4, 0) NULL,
	[fecha_aprovacion] [date] NULL,
	[numero_cotizacion] [numeric](4, 0) NULL,
	[subtoral] [numeric](4, 2) NULL,
	[iva] [numeric](4, 2) NULL,
	[total] [numeric](4, 2) NULL,
 CONSTRAINT [PK_CP_ORDEN_COMPRA] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_ORDEN_COMPRA_DETALLE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_ORDEN_COMPRA_DETALLE](
	[numero] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) NOT NULL,
	[cantidad] [numeric](4, 0) NULL,
	[id_producto] [numeric](4, 0) NULL,
	[costo_unitario] [numeric](4, 0) NULL,
	[subtotal] [numeric](4, 2) NULL,
 CONSTRAINT [PK_CP_ORDEN_COMPRA_DETALLE] PRIMARY KEY CLUSTERED 
(
	[numero] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CP_T_PRODUCTO_X_PROVEEDOR]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CP_T_PRODUCTO_X_PROVEEDOR](
	[codigo] [numeric](4, 0) NOT NULL,
	[cod_producto] [numeric](4, 0) NULL,
	[cod_proveedor] [numeric](4, 0) NULL,
	[costo] [numeric](4, 2) NULL,
 CONSTRAINT [PK_CP_T_PRODUCTO_X_PROVEEDOR] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_M_CUENTA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_M_CUENTA](
	[cod_cuenta] [numeric](4, 0) NOT NULL,
	[cod_tipo_cuenta] [numeric](4, 0) NULL,
	[cod_estado] [numeric](4, 0) NULL,
	[nombre] [varchar](30) NULL,
	[saldo] [money] NULL,
	[saldo_debe] [money] NULL,
	[saldo_haber] [money] NULL,
	[estado_saldo] [numeric](1, 0) NULL,
 CONSTRAINT [PK_CT_M_CUENTA] PRIMARY KEY CLUSTERED 
(
	[cod_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_M_DOCUMENTO_CONTABLE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_M_DOCUMENTO_CONTABLE](
	[cod_documento] [numeric](4, 0) NOT NULL,
	[num_documento] [numeric](8, 0) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_CT_M_DOCUMENTO_CONTABLE] PRIMARY KEY CLUSTERED 
(
	[cod_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_M_MONEDA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_M_MONEDA](
	[cod_moneda] [numeric](4, 0) NOT NULL,
	[descripcion] [varchar](20) NULL,
 CONSTRAINT [PK_CT_M_MONEDA] PRIMARY KEY CLUSTERED 
(
	[cod_moneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_M_PLAN_CUENTA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_M_PLAN_CUENTA](
	[cod_plan_cuenta] [numeric](4, 0) NOT NULL,
	[cod_cuenta] [numeric](4, 0) NULL,
	[cod_sub_cuenta] [numeric](8, 0) NOT NULL,
	[cod_moneda] [numeric](4, 0) NULL,
	[saldo_debe] [money] NULL,
	[saldo_haber] [money] NULL,
 CONSTRAINT [PK_CT_M_PLAN_CUENTA] PRIMARY KEY CLUSTERED 
(
	[cod_plan_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_R_PERIODO_CONTABLE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_R_PERIODO_CONTABLE](
	[cod_periodo] [numeric](4, 0) NOT NULL,
	[cod_estado] [numeric](4, 0) NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[descripcion] [varchar](20) NULL,
 CONSTRAINT [PK_CT_R_PERIODO_CONTABLE] PRIMARY KEY CLUSTERED 
(
	[cod_periodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_R_TIPO_CUENTA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_R_TIPO_CUENTA](
	[cod_tipo_cuenta] [numeric](4, 0) NOT NULL,
	[nombre] [varchar](30) NULL,
	[cod_naturaleza] [numeric](4, 0) NULL,
	[cod_estado] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CT_R_TIPO_CUENTA] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_R_TIPO_TRANSACCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_R_TIPO_TRANSACCION](
	[cod_tipo_transaccion] [numeric](4, 0) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CT_R_TIPO_TRANSACCION] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_T_CABECERA_ASIENTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_T_CABECERA_ASIENTO](
	[num_asiento] [numeric](4, 0) NOT NULL,
	[cod_estado] [numeric](4, 0) NULL,
	[cod_transaccion] [numeric](4, 0) NULL,
	[cod_periodo] [numeric](4, 0) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_anulacion] [datetime] NULL,
	[motivo_anulacion] [varchar](50) NULL,
	[total_cuadre] [money] NULL,
 CONSTRAINT [PK_CT_T_CABECERA_ASIENTO] PRIMARY KEY CLUSTERED 
(
	[num_asiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_T_CABECERA_CIERRE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_CABECERA_CIERRE](
	[num_cierre] [numeric](4, 0) NOT NULL,
	[cod_periodo] [numeric](4, 0) NOT NULL,
	[cod_estado] [numeric](4, 0) NOT NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_fin] [datetime] NULL,
 CONSTRAINT [PK_CT_T_CABECERA_CIERRE] PRIMARY KEY CLUSTERED 
(
	[num_cierre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_T_CABECERA_LIBRO_DIARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_CABECERA_LIBRO_DIARIO](
	[cod_libro_diario] [numeric](4, 0) NOT NULL,
	[cod_transaccion] [numeric](4, 0) NULL,
	[cod_estado] [numeric](4, 0) NULL,
	[fecha_creacion] [datetime] NULL,
 CONSTRAINT [PK_CT_T_CABECERA_LIBRO_DIARIO] PRIMARY KEY CLUSTERED 
(
	[cod_libro_diario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_T_DETALLE_ASIENTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_T_DETALLE_ASIENTO](
	[num_asiento] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) NOT NULL,
	[cod_cuenta] [numeric](4, 0) NOT NULL,
	[tipo_valor] [char](1) NULL,
	[valor] [money] NULL,
 CONSTRAINT [PK_CT_T_DETALLE_ASIENTO] PRIMARY KEY CLUSTERED 
(
	[num_asiento] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_T_DETALLE_CIERRE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_DETALLE_CIERRE](
	[num_cierre] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) NOT NULL,
	[num_asiento] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CT_T_DETALLE_CIERRE] PRIMARY KEY CLUSTERED 
(
	[num_cierre] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_T_DETALLE_LIBRO_DIARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO](
	[cod_libro_diario] [numeric](4, 0) NOT NULL,
	[linea] [numeric](4, 0) NOT NULL,
	[estado_saldo] [numeric](1, 0) NULL,
	[cod_cuenta] [numeric](4, 0) NOT NULL,
 CONSTRAINT [PK_CT_T_DETALLE_LIBRO_DIARIO] PRIMARY KEY CLUSTERED 
(
	[cod_libro_diario] ASC,
	[linea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_T_DOCUMENTO_X_ASIENTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_DOCUMENTO_X_ASIENTO](
	[cod_documento] [numeric](4, 0) NOT NULL,
	[num_asiento] [numeric](4, 0) NOT NULL,
 CONSTRAINT [PK_CT_T_DOCUMENTO_X_ASIENTO] PRIMARY KEY CLUSTERED 
(
	[cod_documento] ASC,
	[num_asiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_T_GASTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_GASTO](
	[cod_gasto] [numeric](14, 0) NOT NULL,
	[cod_cabera_factura] [numeric](4, 0) NOT NULL,
	[cod_cuenta] [numeric](4, 0) NULL,
	[cod_tipo_gasto] [nchar](1) NULL,
	[saldo] [numeric](4, 2) NULL,
 CONSTRAINT [PK_CT_T_GASTO] PRIMARY KEY CLUSTERED 
(
	[cod_gasto] ASC,
	[cod_cabera_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_T_NATURALEZA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_T_NATURALEZA](
	[cod_naturaleza] [numeric](4, 0) NOT NULL,
	[cod_estado] [numeric](4, 0) NULL,
	[nombre] [varchar](30) NULL,
 CONSTRAINT [PK_CT_T_NATURALEZA] PRIMARY KEY CLUSTERED 
(
	[cod_naturaleza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_T_TRANSACCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_T_TRANSACCION](
	[cod_transaccion] [numeric](4, 0) NOT NULL,
	[cod_tipo_transaccion] [numeric](4, 0) NULL,
	[cod_estado] [numeric](4, 0) NULL,
	[cod_facturacion] [numeric](4, 0) NULL,
	[cod_kardex] [numeric](4, 0) NULL,
	[cod_devoluciones] [numeric](4, 0) NULL,
 CONSTRAINT [PK_CT_M_TRANSACCION] PRIMARY KEY CLUSTERED 
(
	[cod_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ESTADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ESTADO](
	[cod_estado] [numeric](4, 0) NOT NULL,
	[descripcion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ESTADO] PRIMARY KEY CLUSTERED 
(
	[cod_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_M_EMPLEADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_M_EMPLEADO](
	[codigo] [numeric](4, 0) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[cedula] [varchar](10) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[cargo] [varchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[fecha_ingreso] [date] NULL,
	[estado] [char](1) NULL,
 CONSTRAINT [PK_FC_M_EMPLEADO] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_M_EMPRESA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_M_EMPRESA](
	[Codigo_Empresa] [numeric](4, 0) NOT NULL,
	[RUC_Empresa] [numeric](13, 0) NOT NULL,
	[RazonSocial_Empresa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_FC_M_EMPRESA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_ANULACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_ANULACION](
	[Numero] [numeric](4, 0) NOT NULL,
	[Codigo_Factura] [numeric](4, 0) NOT NULL,
	[Fecha_Anulacion] [date] NULL,
	[Motivo] [varchar](50) NULL,
 CONSTRAINT [PK_FC_T_ANULACION] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC,
	[Codigo_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_CABECERA_FACTURA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_CABECERA_FACTURA](
	[Codigo_Factura] [numeric](4, 0) NOT NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Codigo_Forma_Pago] [numeric](4, 0) NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Cliente] [numeric](4, 0) NULL,
	[Fecha_Factura] [date] NULL,
	[Subtotal_Factura] [char](6) NULL,
	[Iva_Factura] [char](6) NULL,
	[Total_Factura] [char](6) NULL,
	[Estado_Factura] [char](1) NULL,
 CONSTRAINT [PK_FC_T_CABECERA_FACTURA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_CABECERACAJA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FC_T_CABECERACAJA](
	[Codigo_Caja] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Hora_Cierre] [datetime] NULL,
	[Hora_Inicio] [datetime] NULL,
	[Monto_Cierre] [money] NULL,
	[Monto_Inicial] [money] NULL,
	[Faltante] [money] NULL,
 CONSTRAINT [PK_FC_T_CABECERACAJA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Caja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FC_T_CABECERADEVOLUCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FC_T_CABECERADEVOLUCION](
	[Codigo_Devolucion] [numeric](4, 0) NOT NULL,
	[Codigo_Factura] [numeric](4, 0) NOT NULL,
	[Codigo_empleado] [numeric](4, 0) NULL,
	[Codigo_Cliente] [numeric](4, 0) NULL,
	[Fecha_Devolucion] [date] NULL,
	[Descuento_Devolucion] [numeric](4, 2) NULL,
	[Total_Devolucion] [numeric](4, 2) NULL,
 CONSTRAINT [PK_FC_T_CABECERADEVOLUCION_1] PRIMARY KEY CLUSTERED 
(
	[Codigo_Devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FC_T_CABECERAORDENTRABAJO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_CABECERAORDENTRABAJO](
	[Codigo_OrdenTrabajo] [numeric](4, 0) NOT NULL,
	[Codigo_Servicio] [numeric](4, 0) NULL,
	[Fecha_OrdenTrabajo] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_CABECERAORDENTRABAJO] PRIMARY KEY CLUSTERED 
(
	[Codigo_OrdenTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_CAJAPOREMPLEADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FC_T_CAJAPOREMPLEADO](
	[Codigo_CajaPorEmpleado] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Factura] [numeric](4, 0) NULL,
	[Monto_Inicio] [money] NULL,
	[Monto_Cierre] [money] NULL,
	[Fecha] [date] NULL,
	[Hora_Inicio] [datetime] NULL,
	[Hora_Fin] [datetime] NULL,
 CONSTRAINT [PK_FC_T_CAJAPOREMPLEADO] PRIMARY KEY CLUSTERED 
(
	[Codigo_CajaPorEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FC_T_COTIZACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_COTIZACION](
	[Codigo_Cotizacion] [numeric](4, 0) NOT NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Cliente] [numeric](4, 0) NULL,
	[Fecha_Cotizacion] [date] NULL,
	[Total] [money] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_COTIZACION] PRIMARY KEY CLUSTERED 
(
	[Codigo_Cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_DETALLE_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_DETALLE_PRODUCTO](
	[numero_factura] [numeric](4, 0) NOT NULL,
	[secuencial] [numeric](4, 0) NOT NULL,
	[cod_producto] [numeric](4, 0) NULL,
	[cantidad] [numeric](4, 0) NULL,
	[subtotal] [char](6) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_DETALLE_SERVICIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_DETALLE_SERVICIO](
	[numero_faqctura] [numeric](4, 0) NOT NULL,
	[secuencial] [nchar](10) NULL,
	[cod_servicio] [numeric](4, 0) NULL,
	[Insumos] [numeric](4, 2) NULL,
	[Subtotal] [numeric](4, 2) NULL,
	[observacion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_DETALLECAJA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FC_T_DETALLECAJA](
	[Linea_DetalleCaja] [numeric](4, 0) NOT NULL,
	[Codigo_CajaPorEmpleado] [numeric](4, 0) NOT NULL,
	[Codigo_Caja] [numeric](4, 0) NOT NULL,
	[HoraRegistro] [datetime] NULL,
	[Valor] [money] NULL,
 CONSTRAINT [PK_FC_T_DETALLECAJA_1] PRIMARY KEY CLUSTERED 
(
	[Linea_DetalleCaja] ASC,
	[Codigo_CajaPorEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FC_T_DETALLECAJAPOREMPLEADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_DETALLECAJAPOREMPLEADO](
	[Linea_Moneda] [numeric](4, 0) NOT NULL,
	[Codigo_CajaPorEmpleado] [numeric](4, 0) NOT NULL,
	[Codigo_Moneda] [numeric](4, 0) NULL,
	[TipoMoneda] [varchar](20) NULL,
	[Concepto] [varchar](20) NULL,
	[Cantidad] [numeric](4, 0) NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_FC_T_DETALLECAJAPOREMPLEADO] PRIMARY KEY CLUSTERED 
(
	[Linea_Moneda] ASC,
	[Codigo_CajaPorEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_DETALLECOTIZACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FC_T_DETALLECOTIZACION](
	[Linea_DetalleCotizacion] [numeric](4, 0) NOT NULL,
	[Codigo_Cotizacion] [numeric](4, 0) NOT NULL,
	[Codigo_Producto] [numeric](4, 0) NULL,
	[Cantidad_Producto] [numeric](2, 0) NULL,
	[Precio_Producto] [money] NULL,
	[Subtotal] [money] NULL,
 CONSTRAINT [PK_FC_T_DETALLECOTIZACION] PRIMARY KEY CLUSTERED 
(
	[Linea_DetalleCotizacion] ASC,
	[Codigo_Cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FC_T_DETALLEDEVOLUCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_DETALLEDEVOLUCION](
	[Linea_DetalleDevolucion] [numeric](4, 0) NOT NULL,
	[Codigo_Devolucion] [numeric](4, 0) NOT NULL,
	[Codigo_Producto] [numeric](4, 0) NOT NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Observacion_Devolucion] [varchar](50) NULL,
	[Cantidad_Devolucion] [numeric](2, 0) NULL,
	[Precio_ProductoDevolucion] [money] NULL,
	[Subtotal_DetalleDevolucion] [money] NULL,
 CONSTRAINT [PK_FC_T_DETALLEDEVOLUCION_1] PRIMARY KEY CLUSTERED 
(
	[Linea_DetalleDevolucion] ASC,
	[Codigo_Devolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_DETALLEORDENPAGO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_DETALLEORDENPAGO](
	[Linea_OrdenPago] [numeric](4, 0) NOT NULL,
	[Codigo_OrdenTrabajo] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Area] [numeric](4, 0) NULL,
	[Fecha_Inicial] [date] NULL,
	[Fecha_Fin] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_DETALLEORDENPAGO] PRIMARY KEY CLUSTERED 
(
	[Linea_OrdenPago] ASC,
	[Codigo_OrdenTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_FORMAPAGO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_FORMAPAGO](
	[Codigo_FormaPago] [numeric](4, 0) NOT NULL,
	[Descripcion_FormaPago] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_FORMAPAGO] PRIMARY KEY CLUSTERED 
(
	[Codigo_FormaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_PAGOFACTURA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FC_T_PAGOFACTURA](
	[Codigo_Factura] [numeric](4, 0) NOT NULL,
	[Codigo_FormaPago] [numeric](4, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FC_T_SERVICIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_SERVICIO](
	[Codigo_Servicio] [numeric](4, 0) NOT NULL,
	[Codigo_TipoServicio] [numeric](4, 0) NULL,
	[Codigo_Area] [numeric](4, 0) NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Fecha_Servicio] [date] NULL,
	[Fecha_Realizacion] [datetime] NULL,
	[Fecha_Culminacion] [datetime] NULL,
	[Dimension] [numeric](2, 0) NULL,
	[Total_Servicio] [numeric](3, 2) NULL,
	[Observacion] [varchar](70) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_SERVICIO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FC_T_TIPOSERVICIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FC_T_TIPOSERVICIO](
	[Codigo_TipoServicio] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_TIPOSERVICIO] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_ESTADO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_ESTADO_PRODUCTO](
	[Codigo] [numeric](4, 0) NOT NULL,
	[Descripcion_EstadoProducto] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_M_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
/****** Object:  Table [dbo].[IN_M_EMPLEADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_M_EMPLEADO](
	[Codigo_Empleado] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[Cedula_Empleado] [numeric](10, 0) NOT NULL,
	[Nombre_Empleado] [varchar](40) NOT NULL,
	[Codigo_Tarea] [numeric](4, 0) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Codigo_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_M_MOVIMIENTO_INVENTARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
/****** Object:  Table [dbo].[IN_M_ORGANIZACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_M_ORGANIZACION](
	[Codigo_Organizacion] [numeric](4, 0) NOT NULL,
	[Nombre_Organizacion] [varchar](40) NOT NULL,
	[Direccion_Organizacion] [varchar](40) NOT NULL,
	[Telefono_Organizacion] [numeric](13, 0) NOT NULL,
 CONSTRAINT [PK_Organizacion] PRIMARY KEY CLUSTERED 
(
	[Codigo_Organizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_M_PERCHA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
/****** Object:  Table [dbo].[IN_M_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
/****** Object:  Table [dbo].[IN_R_TIPO_DOCUMENTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
/****** Object:  Table [dbo].[IN_R_TIPO_MEDIDA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
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
/****** Object:  Table [dbo].[IN_R_TIPO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_R_TIPO_PRODUCTO](
	[Codigo_TipoProducto] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[DescripcionTipoProducto] [varchar](30) NOT NULL,
	[Estado] [char](1) NOT NULL,
 CONSTRAINT [PK_SVA_M_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_R_TIPO_TRANSACCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_R_TIPO_TRANSACCION](
	[Codigo_TipoTrasanccion] [numeric](4, 0) NOT NULL,
	[Descripcion_TipoTransaccion] [varchar](40) NOT NULL,
 CONSTRAINT [PK_TipoTransaccion] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoTrasanccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_R_TRANSFERENCIA_INVENTARIO_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_R_TRANSFERENCIA_INVENTARIO_BODEGA](
	[CodigoTransferenciaInventario] [numeric](4, 0) IDENTITY(1,1) NOT NULL,
	[BodegaSaliente] [varchar](20) NOT NULL,
	[BodegaEntrante] [varchar](20) NOT NULL,
	[ResponsableBodega] [varchar](20) NOT NULL,
	[Motivo] [varchar](60) NULL,
	[EstadoTransferencia] [char](1) NOT NULL,
 CONSTRAINT [PK_IN_R_TRANSFERENCIA_INVENTARIO_BODEGA] PRIMARY KEY CLUSTERED 
(
	[CodigoTransferenciaInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_T_CABECERATOMAFISICA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_T_CABECERATOMAFISICA](
	[Codigo_TomaFisica] [numeric](4, 0) NOT NULL,
	[Codigo_Bodega] [numeric](4, 0) NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Fecha_Inicio] [date] NULL,
	[Fecha_Fin] [date] NULL,
	[Observacion] [varchar](100) NULL,
	[Codigo_Transaccion] [numeric](4, 0) NULL,
	[Codigo_Asiento] [numeric](4, 0) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_FC_T_CABECERAFISICA] PRIMARY KEY CLUSTERED 
(
	[Codigo_TomaFisica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_T_DETALLE_INGRESOEGRESO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IN_T_DETALLE_INGRESOEGRESO](
	[Linea_IngresoEgreso] [numeric](4, 0) NOT NULL,
	[Codigo_Producto] [numeric](4, 0) NOT NULL,
	[Codigo_IngresoEgreso] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NOT NULL,
	[Codigo_TipoTransaccion] [numeric](4, 0) NOT NULL,
	[Codigo_TipoDocumento] [numeric](4, 0) NOT NULL,
	[Codigo_Organizacion] [numeric](4, 0) NOT NULL,
	[Codigo_Proveedor] [numeric](4, 0) NOT NULL,
	[Anio_Ingreso] [date] NOT NULL,
	[costo_producto] [nchar](10) NULL,
	[costo_total] [nchar](10) NULL,
	[Cantidad] [numeric](3, 0) NOT NULL,
 CONSTRAINT [PK_Detalle_Ingreso_1] PRIMARY KEY CLUSTERED 
(
	[Linea_IngresoEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IN_T_DETALLE_KARDEX]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_T_DETALLE_KARDEX](
	[Codigo_Kardex] [numeric](4, 0) NOT NULL,
	[Linea_IngresoEgreso] [numeric](4, 0) NOT NULL,
	[fecha] [date] NULL,
	[cantidad] [numeric](4, 0) NULL,
	[costo_unitario] [numeric](5, 2) NULL,
	[tipo_movimiento] [varchar](50) NULL,
 CONSTRAINT [PK_IN_T_DETALLE_KARDEX] PRIMARY KEY CLUSTERED 
(
	[Codigo_Kardex] ASC,
	[Linea_IngresoEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_T_DETALLEFISICA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_T_DETALLEFISICA](
	[Linea_TomaFisica] [numeric](4, 0) NOT NULL,
	[Codigo_TomaFisica] [numeric](4, 0) NOT NULL,
	[Codigo_Producto] [numeric](4, 0) NULL,
	[Existencia_Sistema] [numeric](3, 0) NULL,
	[Existencia_Fisica] [numeric](3, 0) NULL,
	[Diferencia] [numeric](3, 0) NULL,
	[Observacion] [varchar](100) NULL,
 CONSTRAINT [PK_FC_T_DETALLEFISICA] PRIMARY KEY CLUSTERED 
(
	[Linea_TomaFisica] ASC,
	[Codigo_TomaFisica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_T_INGRESOEGRESO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IN_T_INGRESOEGRESO](
	[Codigo_IngresoEgreso] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NOT NULL,
	[Codigo_TipoTransaccion] [numeric](4, 0) NOT NULL,
	[Codigo_TipoDocumento] [numeric](4, 0) NOT NULL,
	[Codigo_Organizacion] [numeric](4, 0) NOT NULL,
	[Codigo_Proveedor] [numeric](4, 0) NOT NULL,
	[Anio_Ingreso] [date] NOT NULL,
	[Fecha_Transaccion] [date] NOT NULL,
	[Tipo_IngresoEgreso] [char](1) NULL,
	[Detalle_Transaccion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[Codigo_IngresoEgreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IN_T_KARDEX]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IN_T_KARDEX](
	[Codigo_Kardex] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NOT NULL,
	[Numero_Kardex] [numeric](3, 0) NOT NULL,
	[Metodo] [numeric](1, 0) NOT NULL,
	[cod_producto] [numeric](4, 0) NOT NULL,
	[saldo_inicial] [numeric](4, 0) NULL,
 CONSTRAINT [PK_Kardex] PRIMARY KEY CLUSTERED 
(
	[Codigo_Kardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RH_M_AREADESERVICIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_AREADESERVICIO](
	[Codigo_Area] [numeric](4, 0) NOT NULL,
	[Descripcion_Area] [varchar](50) NULL,
	[Codigo_TipoArea] [numeric](4, 0) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_RH_M_AREADESERVICIO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_CARGO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_CARGO](
	[Codigo_Cargo] [numeric](4, 0) NOT NULL,
	[Nombre_Cargo] [varchar](50) NULL,
	[Fecha_Creacion] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_RH_M_CARGO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_CARGOPORDEPARTAMENTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RH_M_CARGOPORDEPARTAMENTO](
	[Codigo_Cargo] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NOT NULL,
	[Jefe] [bit] NULL,
 CONSTRAINT [PK_RH_M_CARGOPORDEPARTAMENTO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Cargo] ASC,
	[Codigo_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RH_M_CIUDAD]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_CIUDAD](
	[Numero_Ciudad] [numeric](4, 0) NOT NULL,
	[Codigo_Provincia] [numeric](4, 0) NULL,
	[Nombre_Ciudad] [varchar](50) NULL,
 CONSTRAINT [PK_RH_M_CIUDAD] PRIMARY KEY CLUSTERED 
(
	[Numero_Ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_CLIENTE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_CLIENTE](
	[Codigo_Cliente] [numeric](4, 0) NOT NULL,
	[RUC_Cliente] [numeric](13, 0) NOT NULL,
	[Cedula_Cliente] [numeric](10, 0) NOT NULL,
	[RazonSocial_Cliente] [varchar](40) NOT NULL,
	[Nombre_Cliente] [varchar](40) NOT NULL,
	[Apellido_Cliente] [varchar](40) NOT NULL,
	[Direccion_Cliente] [varchar](50) NOT NULL,
	[Telefono_Cliente] [numeric](10, 0) NOT NULL,
	[Genero_Cliente] [char](1) NOT NULL,
	[Estado_Cliente] [char](1) NOT NULL,
 CONSTRAINT [PK_RH_M_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[Codigo_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_DEPARTAMENTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_DEPARTAMENTO](
	[Codigo_Departamento] [numeric](4, 0) NOT NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Nombre_Departamento] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_RH_M_DEPARTAMENTO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_DIRECCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_DIRECCION](
	[Secuencial_Direccion] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Proveedor] [numeric](4, 0) NULL,
	[Codigo_Cliente] [numeric](4, 0) NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Codigo_Tipo_Direccion] [numeric](4, 0) NULL,
	[Numero_Parroquia] [numeric](4, 0) NULL,
	[Calle_Principal] [varchar](50) NOT NULL,
	[Numeracion] [numeric](3, 0) NULL,
	[Calle_Secundaria] [varchar](50) NULL,
	[Descripcion] [varchar](70) NULL,
 CONSTRAINT [PK_RH_M_DIRECCION] PRIMARY KEY CLUSTERED 
(
	[Secuencial_Direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_EMPLEADOPORAREA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RH_M_EMPLEADOPORAREA](
	[Codigo_Empleado] [numeric](4, 0) NOT NULL,
	[Codigo_Area] [numeric](4, 0) NOT NULL,
 CONSTRAINT [PK_RH_M_EMPLEADOPORAREA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Empleado] ASC,
	[Codigo_Area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RH_M_PARROQUIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_PARROQUIA](
	[Numero_Parroquia] [numeric](4, 0) NOT NULL,
	[Numero_Ciudad] [numeric](4, 0) NULL,
	[Nombre_Parroquia] [varchar](50) NULL,
 CONSTRAINT [PK_RH_M_PARROQUIA] PRIMARY KEY CLUSTERED 
(
	[Numero_Parroquia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_PROVINCIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_PROVINCIA](
	[Codigo_Provincia] [numeric](4, 0) NOT NULL,
	[Nombre_Provincia] [varchar](50) NULL,
 CONSTRAINT [PK_RH_M_PROVINCIA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_TELEFONO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RH_M_TELEFONO](
	[Secuencial_Telefono] [numeric](4, 0) NOT NULL,
	[Codigo_Provincia] [numeric](4, 0) NULL,
	[Codigo_TipoTelefono] [numeric](4, 0) NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Cliente] [numeric](4, 0) NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Codigo_Proveedor] [numeric](4, 0) NULL,
	[Numero_Telefono] [numeric](6, 0) NULL,
 CONSTRAINT [PK_RH_M_TELEFONO] PRIMARY KEY CLUSTERED 
(
	[Secuencial_Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RH_M_TIPOAREA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_TIPOAREA](
	[Codigo_TipoArea] [numeric](4, 0) NOT NULL,
	[Descripcion_TipoArea] [varchar](50) NULL,
	[Precio] [numeric](3, 2) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_RH_M_TIPOAREA] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_M_TIPODIRECCION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_M_TIPODIRECCION](
	[Codigo_TipoDireccion] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_RH_M_TIPODIRECCION] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RH_T_TIPOTELEFONO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RH_T_TIPOTELEFONO](
	[Codigo_TipoTelefono] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_RH_T_TIPOTELEFONO] PRIMARY KEY CLUSTERED 
(
	[Codigo_TipoTelefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_AUDITORIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SG_M_AUDITORIA](
	[Codigo_Auditoria] [numeric](4, 0) NOT NULL,
	[Codigo_OpcionMenu] [numeric](4, 0) NULL,
	[Codigo_Usuario] [numeric](4, 0) NULL,
	[Fecha_Acceso] [date] NULL,
	[Fecha_Salida] [date] NULL,
 CONSTRAINT [PK_SG_M_AUDITORIA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Auditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SG_M_BOTON]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_BOTON](
	[Codigo] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_BOTON] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_MODULO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_MODULO](
	[Codigo_Modulo] [numeric](4, 0) NOT NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_MODULO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Modulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_OBJETO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_OBJETO](
	[Codigo_Objeto] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Tipo_Objetivo] [char](1) NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_OBJETO] PRIMARY KEY CLUSTERED 
(
	[Codigo_Objeto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_OPCIONMENU]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_OPCIONMENU](
	[Codigo_OpcionMenu] [numeric](4, 0) NOT NULL,
	[Codigo_Modulo] [numeric](4, 0) NULL,
	[Descripcion] [varchar](50) NULL,
	[Opcion_Menu] [varchar](50) NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_OPCIONMENU] PRIMARY KEY CLUSTERED 
(
	[Codigo_OpcionMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_OPCIONMENUPERFIL]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_OPCIONMENUPERFIL](
	[Codigo_OpcionPerfil] [numeric](4, 0) NOT NULL,
	[Codigo_Perfil] [numeric](4, 0) NULL,
	[Codigo_OpcionMenu] [numeric](4, 0) NULL,
	[Fecha_Creacion] [date] NULL,
	[Fecha_Expiracion] [date] NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_OPCIONMENUPERFIL] PRIMARY KEY CLUSTERED 
(
	[Codigo_OpcionPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_PANTALLA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_PANTALLA](
	[Codigo_Pantalla] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Padre] [numeric](4, 0) NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_PANTALLA] PRIMARY KEY CLUSTERED 
(
	[Codigo_Pantalla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_PERFIL]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_PERFIL](
	[Codigo_Perfil] [numeric](4, 0) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Fecha_Expiracion] [date] NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
 CONSTRAINT [PK_SG_M_PERFIL] PRIMARY KEY CLUSTERED 
(
	[Codigo_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_PERFILUSUARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_PERFILUSUARIO](
	[Codigo_PerfilUsuario] [numeric](4, 0) NOT NULL,
	[Codigo_Perfil] [numeric](4, 0) NULL,
	[Codigo_Usuario] [numeric](4, 0) NULL,
	[Fecha_Expiracion] [date] NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_PERFILUSUARIO] PRIMARY KEY CLUSTERED 
(
	[Codigo_PerfilUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_PRIVILEGIOSUSUARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_PRIVILEGIOSUSUARIO](
	[Codigo_PrivilegioUsuario] [numeric](4, 0) NOT NULL,
	[Codigo_Usuario] [numeric](4, 0) NULL,
	[Codigo_Objeto] [numeric](4, 0) NULL,
	[Fecha_Expiracion] [date] NULL,
	[Privilegio_Selec] [numeric](3, 0) NULL,
	[Privilegio_Insert] [numeric](3, 0) NULL,
	[Privilegio_Update] [numeric](3, 0) NULL,
	[Usuario_Crea] [varchar](50) NULL,
	[Fecha_Crea] [date] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_PRIVILEGIOSUSUARIO] PRIMARY KEY CLUSTERED 
(
	[Codigo_PrivilegioUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_M_USUARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SG_M_USUARIO](
	[Codigo_Usuario] [numeric](4, 0) NOT NULL,
	[Codigo_Empleado] [numeric](4, 0) NULL,
	[Codigo_Empresa] [numeric](4, 0) NULL,
	[Usuario] [varchar](50) NULL,
	[Pasword] [varchar](100) NULL,
	[Fecha_Crea] [datetime] NULL,
	[Estado] [char](1) NULL,
 CONSTRAINT [PK_SG_M_USUARIO_1] PRIMARY KEY CLUSTERED 
(
	[Codigo_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SG_T_OPCIONMENUXBOTON]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SG_T_OPCIONMENUXBOTON](
	[Codigo_OPCIONMENUXBOTON] [numeric](4, 0) NOT NULL,
	[Codigo_OpcionMenu] [numeric](4, 0) NULL,
	[Codigo_Boton] [numeric](4, 0) NULL,
	[Uso] [bit] NULL,
 CONSTRAINT [PK_SG_T_OPCIONMENUXBOTON] PRIMARY KEY CLUSTERED 
(
	[Codigo_OPCIONMENUXBOTON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[v_reporte]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_reporte] as
SELECT * From  IN_M_PRODUCTO


GO
ALTER TABLE [dbo].[CP_CABECERA_COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_CP_CABECERA_COTIZACION_CP_CABECERA_PEDIDO] FOREIGN KEY([num_pedido])
REFERENCES [dbo].[CP_CABECERA_PEDIDO] ([numero])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CP_CABECERA_COTIZACION] CHECK CONSTRAINT [FK_CP_CABECERA_COTIZACION_CP_CABECERA_PEDIDO]
GO
ALTER TABLE [dbo].[CP_CABECERA_COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_CP_CABECERA_COTIZACION_CP_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[CP_ESTADO] ([codigo])
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[CP_CABECERA_COTIZACION] CHECK CONSTRAINT [FK_CP_CABECERA_COTIZACION_CP_ESTADO]
GO
ALTER TABLE [dbo].[CP_DETALLE_COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_CP_DETALLE_COTIZACION_CP_CABECERA_COTIZACION] FOREIGN KEY([numero])
REFERENCES [dbo].[CP_CABECERA_COTIZACION] ([numero])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CP_DETALLE_COTIZACION] CHECK CONSTRAINT [FK_CP_DETALLE_COTIZACION_CP_CABECERA_COTIZACION]
GO
ALTER TABLE [dbo].[CP_DETALLE_DESPACHO]  WITH CHECK ADD  CONSTRAINT [FK_CP_DETALLE_DESPACHO_CP_CABECERA_DESPACHO] FOREIGN KEY([numero])
REFERENCES [dbo].[CP_CABECERA_DESPACHO] ([numero])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CP_DETALLE_DESPACHO] CHECK CONSTRAINT [FK_CP_DETALLE_DESPACHO_CP_CABECERA_DESPACHO]
GO
ALTER TABLE [dbo].[CP_DETALLE_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_CP_DETALLE_PEDIDO_CP_CABECERA_PEDIDO] FOREIGN KEY([numero])
REFERENCES [dbo].[CP_CABECERA_PEDIDO] ([numero])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CP_DETALLE_PEDIDO] CHECK CONSTRAINT [FK_CP_DETALLE_PEDIDO_CP_CABECERA_PEDIDO]
GO
ALTER TABLE [dbo].[CP_ORDEN_COMPRA]  WITH CHECK ADD  CONSTRAINT [FK_CP_ORDEN_COMPRA_CP_CABECERA_COTIZACION] FOREIGN KEY([numero_cotizacion])
REFERENCES [dbo].[CP_CABECERA_COTIZACION] ([numero])
GO
ALTER TABLE [dbo].[CP_ORDEN_COMPRA] CHECK CONSTRAINT [FK_CP_ORDEN_COMPRA_CP_CABECERA_COTIZACION]
GO
ALTER TABLE [dbo].[CP_ORDEN_COMPRA_DETALLE]  WITH CHECK ADD  CONSTRAINT [FK_CP_ORDEN_COMPRA_DETALLE_CP_ORDEN_COMPRA] FOREIGN KEY([numero])
REFERENCES [dbo].[CP_ORDEN_COMPRA] ([numero])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CP_ORDEN_COMPRA_DETALLE] CHECK CONSTRAINT [FK_CP_ORDEN_COMPRA_DETALLE_CP_ORDEN_COMPRA]
GO
ALTER TABLE [dbo].[CP_T_PRODUCTO_X_PROVEEDOR]  WITH CHECK ADD  CONSTRAINT [FK_CP_T_PRODUCTO_X_PROVEEDOR_CP_M_PROVEEDOR] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[CP_M_PROVEEDOR] ([Codigo_Proveedor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CP_T_PRODUCTO_X_PROVEEDOR] CHECK CONSTRAINT [FK_CP_T_PRODUCTO_X_PROVEEDOR_CP_M_PROVEEDOR]
GO
ALTER TABLE [dbo].[CP_T_PRODUCTO_X_PROVEEDOR]  WITH CHECK ADD  CONSTRAINT [FK_CP_T_PRODUCTO_X_PROVEEDOR_IN_M_PRODUCTO] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[CP_T_PRODUCTO_X_PROVEEDOR] CHECK CONSTRAINT [FK_CP_T_PRODUCTO_X_PROVEEDOR_IN_M_PRODUCTO]
GO
ALTER TABLE [dbo].[CT_M_CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_CUENTA_CT_R_TIPO_CUENTA1] FOREIGN KEY([cod_tipo_cuenta])
REFERENCES [dbo].[CT_R_TIPO_CUENTA] ([cod_tipo_cuenta])
GO
ALTER TABLE [dbo].[CT_M_CUENTA] CHECK CONSTRAINT [FK_CT_M_CUENTA_CT_R_TIPO_CUENTA1]
GO
ALTER TABLE [dbo].[CT_M_CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_CUENTA_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[ESTADO] ([cod_estado])
GO
ALTER TABLE [dbo].[CT_M_CUENTA] CHECK CONSTRAINT [FK_CT_M_CUENTA_ESTADO]
GO
ALTER TABLE [dbo].[CT_M_PLAN_CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_PLAN_CUENTA_CT_M_CUENTA] FOREIGN KEY([cod_cuenta])
REFERENCES [dbo].[CT_M_CUENTA] ([cod_cuenta])
GO
ALTER TABLE [dbo].[CT_M_PLAN_CUENTA] CHECK CONSTRAINT [FK_CT_M_PLAN_CUENTA_CT_M_CUENTA]
GO
ALTER TABLE [dbo].[CT_M_PLAN_CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_PLAN_CUENTA_CT_M_MONEDA] FOREIGN KEY([cod_moneda])
REFERENCES [dbo].[CT_M_MONEDA] ([cod_moneda])
GO
ALTER TABLE [dbo].[CT_M_PLAN_CUENTA] CHECK CONSTRAINT [FK_CT_M_PLAN_CUENTA_CT_M_MONEDA]
GO
ALTER TABLE [dbo].[CT_R_PERIODO_CONTABLE]  WITH CHECK ADD  CONSTRAINT [FK_CT_R_PERIODO_CONTABLE_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[ESTADO] ([cod_estado])
GO
ALTER TABLE [dbo].[CT_R_PERIODO_CONTABLE] CHECK CONSTRAINT [FK_CT_R_PERIODO_CONTABLE_ESTADO]
GO
ALTER TABLE [dbo].[CT_R_TIPO_CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CT_R_TIPO_CUENTA_CT_T_NATURALEZA] FOREIGN KEY([cod_naturaleza])
REFERENCES [dbo].[CT_T_NATURALEZA] ([cod_naturaleza])
GO
ALTER TABLE [dbo].[CT_R_TIPO_CUENTA] CHECK CONSTRAINT [FK_CT_R_TIPO_CUENTA_CT_T_NATURALEZA]
GO
ALTER TABLE [dbo].[CT_R_TIPO_CUENTA]  WITH CHECK ADD  CONSTRAINT [FK_CT_R_TIPO_CUENTA_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[ESTADO] ([cod_estado])
GO
ALTER TABLE [dbo].[CT_R_TIPO_CUENTA] CHECK CONSTRAINT [FK_CT_R_TIPO_CUENTA_ESTADO]
GO
ALTER TABLE [dbo].[CT_T_CABECERA_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_CABECERA_ASIENTO_CT_M_TRANSACCION] FOREIGN KEY([cod_transaccion])
REFERENCES [dbo].[CT_T_TRANSACCION] ([cod_transaccion])
GO
ALTER TABLE [dbo].[CT_T_CABECERA_ASIENTO] CHECK CONSTRAINT [FK_CT_T_CABECERA_ASIENTO_CT_M_TRANSACCION]
GO
ALTER TABLE [dbo].[CT_T_CABECERA_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_CABECERA_ASIENTO_CT_R_PERIODO_CONTABLE] FOREIGN KEY([cod_transaccion])
REFERENCES [dbo].[CT_R_PERIODO_CONTABLE] ([cod_periodo])
GO
ALTER TABLE [dbo].[CT_T_CABECERA_ASIENTO] CHECK CONSTRAINT [FK_CT_T_CABECERA_ASIENTO_CT_R_PERIODO_CONTABLE]
GO
ALTER TABLE [dbo].[CT_T_CABECERA_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_CABECERA_ASIENTO_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[ESTADO] ([cod_estado])
GO
ALTER TABLE [dbo].[CT_T_CABECERA_ASIENTO] CHECK CONSTRAINT [FK_CT_T_CABECERA_ASIENTO_ESTADO]
GO
ALTER TABLE [dbo].[CT_T_CABECERA_CIERRE]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_CABECERA_CIERRE_CT_R_PERIODO_CONTABLE] FOREIGN KEY([cod_periodo])
REFERENCES [dbo].[CT_R_PERIODO_CONTABLE] ([cod_periodo])
GO
ALTER TABLE [dbo].[CT_T_CABECERA_CIERRE] CHECK CONSTRAINT [FK_CT_T_CABECERA_CIERRE_CT_R_PERIODO_CONTABLE]
GO
ALTER TABLE [dbo].[CT_T_CABECERA_CIERRE]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_CABECERA_CIERRE_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[ESTADO] ([cod_estado])
GO
ALTER TABLE [dbo].[CT_T_CABECERA_CIERRE] CHECK CONSTRAINT [FK_CT_T_CABECERA_CIERRE_ESTADO]
GO
ALTER TABLE [dbo].[CT_T_CABECERA_LIBRO_DIARIO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_CABECERA_LIBRO_DIARIO_CT_M_TRANSACCION] FOREIGN KEY([cod_transaccion])
REFERENCES [dbo].[CT_T_TRANSACCION] ([cod_transaccion])
GO
ALTER TABLE [dbo].[CT_T_CABECERA_LIBRO_DIARIO] CHECK CONSTRAINT [FK_CT_T_CABECERA_LIBRO_DIARIO_CT_M_TRANSACCION]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_ASIENTO_CT_M_CUENTA] FOREIGN KEY([cod_cuenta])
REFERENCES [dbo].[CT_M_CUENTA] ([cod_cuenta])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_ASIENTO] CHECK CONSTRAINT [FK_CT_T_DETALLE_ASIENTO_CT_M_CUENTA]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_ASIENTO_CT_T_CABECERA_ASIENTO] FOREIGN KEY([num_asiento])
REFERENCES [dbo].[CT_T_CABECERA_ASIENTO] ([num_asiento])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_ASIENTO] CHECK CONSTRAINT [FK_CT_T_DETALLE_ASIENTO_CT_T_CABECERA_ASIENTO]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_CIERRE]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_CIERRE_CT_T_CABECERA_ASIENTO] FOREIGN KEY([num_asiento])
REFERENCES [dbo].[CT_T_CABECERA_ASIENTO] ([num_asiento])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_CIERRE] CHECK CONSTRAINT [FK_CT_T_DETALLE_CIERRE_CT_T_CABECERA_ASIENTO]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_CIERRE]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_CIERRE_CT_T_CABECERA_CIERRE] FOREIGN KEY([num_cierre])
REFERENCES [dbo].[CT_T_CABECERA_CIERRE] ([num_cierre])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_CIERRE] CHECK CONSTRAINT [FK_CT_T_DETALLE_CIERRE_CT_T_CABECERA_CIERRE]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_LIBRO_DIARIO_CT_M_CUENTA] FOREIGN KEY([cod_cuenta])
REFERENCES [dbo].[CT_M_CUENTA] ([cod_cuenta])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO] CHECK CONSTRAINT [FK_CT_T_DETALLE_LIBRO_DIARIO_CT_M_CUENTA]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_LIBRO_DIARIO_CT_M_CUENTA1] FOREIGN KEY([cod_cuenta])
REFERENCES [dbo].[CT_M_CUENTA] ([cod_cuenta])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO] CHECK CONSTRAINT [FK_CT_T_DETALLE_LIBRO_DIARIO_CT_M_CUENTA1]
GO
ALTER TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DETALLE_LIBRO_DIARIO_CT_T_CABECERA_LIBRO_DIARIO] FOREIGN KEY([cod_libro_diario])
REFERENCES [dbo].[CT_T_CABECERA_LIBRO_DIARIO] ([cod_libro_diario])
GO
ALTER TABLE [dbo].[CT_T_DETALLE_LIBRO_DIARIO] CHECK CONSTRAINT [FK_CT_T_DETALLE_LIBRO_DIARIO_CT_T_CABECERA_LIBRO_DIARIO]
GO
ALTER TABLE [dbo].[CT_T_DOCUMENTO_X_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DOCUMENTO_X_ASIENTO_CT_M_DOCUMENTO_CONTABLE] FOREIGN KEY([cod_documento])
REFERENCES [dbo].[CT_M_DOCUMENTO_CONTABLE] ([cod_documento])
GO
ALTER TABLE [dbo].[CT_T_DOCUMENTO_X_ASIENTO] CHECK CONSTRAINT [FK_CT_T_DOCUMENTO_X_ASIENTO_CT_M_DOCUMENTO_CONTABLE]
GO
ALTER TABLE [dbo].[CT_T_DOCUMENTO_X_ASIENTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_DOCUMENTO_X_ASIENTO_CT_T_CABECERA_ASIENTO] FOREIGN KEY([num_asiento])
REFERENCES [dbo].[CT_T_CABECERA_ASIENTO] ([num_asiento])
GO
ALTER TABLE [dbo].[CT_T_DOCUMENTO_X_ASIENTO] CHECK CONSTRAINT [FK_CT_T_DOCUMENTO_X_ASIENTO_CT_T_CABECERA_ASIENTO]
GO
ALTER TABLE [dbo].[CT_T_GASTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_GASTO_CT_M_CUENTA] FOREIGN KEY([cod_cuenta])
REFERENCES [dbo].[CT_M_CUENTA] ([cod_cuenta])
GO
ALTER TABLE [dbo].[CT_T_GASTO] CHECK CONSTRAINT [FK_CT_T_GASTO_CT_M_CUENTA]
GO
ALTER TABLE [dbo].[CT_T_GASTO]  WITH CHECK ADD  CONSTRAINT [FK_CT_T_GASTO_FC_T_CABECERA_FACTURA] FOREIGN KEY([cod_cabera_factura])
REFERENCES [dbo].[FC_T_CABECERA_FACTURA] ([Codigo_Factura])
GO
ALTER TABLE [dbo].[CT_T_GASTO] CHECK CONSTRAINT [FK_CT_T_GASTO_FC_T_CABECERA_FACTURA]
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_TRANSACCION_CT_R_TIPO_TRANSACCION] FOREIGN KEY([cod_tipo_transaccion])
REFERENCES [dbo].[CT_R_TIPO_TRANSACCION] ([cod_tipo_transaccion])
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION] CHECK CONSTRAINT [FK_CT_M_TRANSACCION_CT_R_TIPO_TRANSACCION]
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_TRANSACCION_ESTADO] FOREIGN KEY([cod_estado])
REFERENCES [dbo].[ESTADO] ([cod_estado])
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION] CHECK CONSTRAINT [FK_CT_M_TRANSACCION_ESTADO]
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_TRANSACCION_FC_T_CABECERA_FACTURA] FOREIGN KEY([cod_facturacion])
REFERENCES [dbo].[FC_T_CABECERA_FACTURA] ([Codigo_Factura])
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION] CHECK CONSTRAINT [FK_CT_M_TRANSACCION_FC_T_CABECERA_FACTURA]
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION]  WITH CHECK ADD  CONSTRAINT [FK_CT_M_TRANSACCION_FC_T_CABECERADEVOLUCION] FOREIGN KEY([cod_devoluciones])
REFERENCES [dbo].[FC_T_CABECERADEVOLUCION] ([Codigo_Devolucion])
GO
ALTER TABLE [dbo].[CT_T_TRANSACCION] CHECK CONSTRAINT [FK_CT_M_TRANSACCION_FC_T_CABECERADEVOLUCION]
GO
ALTER TABLE [dbo].[FC_T_CABECERA_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERA_FACTURA_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[FC_T_CABECERA_FACTURA] CHECK CONSTRAINT [FK_FC_T_CABECERA_FACTURA_Empleado]
GO
ALTER TABLE [dbo].[FC_T_CABECERA_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERA_FACTURA_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[FC_T_CABECERA_FACTURA] CHECK CONSTRAINT [FK_FC_T_CABECERA_FACTURA_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[FC_T_CABECERA_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERA_FACTURA_RH_M_CLIENTE] FOREIGN KEY([Codigo_Cliente])
REFERENCES [dbo].[RH_M_CLIENTE] ([Codigo_Cliente])
GO
ALTER TABLE [dbo].[FC_T_CABECERA_FACTURA] CHECK CONSTRAINT [FK_FC_T_CABECERA_FACTURA_RH_M_CLIENTE]
GO
ALTER TABLE [dbo].[FC_T_CABECERACAJA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERACAJA_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[FC_T_CABECERACAJA] CHECK CONSTRAINT [FK_FC_T_CABECERACAJA_Empleado]
GO
ALTER TABLE [dbo].[FC_T_CABECERADEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERADEVOLUCION_FC_T_CABECERA_FACTURA] FOREIGN KEY([Codigo_Factura])
REFERENCES [dbo].[FC_T_CABECERA_FACTURA] ([Codigo_Factura])
GO
ALTER TABLE [dbo].[FC_T_CABECERADEVOLUCION] CHECK CONSTRAINT [FK_FC_T_CABECERADEVOLUCION_FC_T_CABECERA_FACTURA]
GO
ALTER TABLE [dbo].[FC_T_CABECERADEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERADEVOLUCION_RH_M_CLIENTE] FOREIGN KEY([Codigo_Cliente])
REFERENCES [dbo].[RH_M_CLIENTE] ([Codigo_Cliente])
GO
ALTER TABLE [dbo].[FC_T_CABECERADEVOLUCION] CHECK CONSTRAINT [FK_FC_T_CABECERADEVOLUCION_RH_M_CLIENTE]
GO
ALTER TABLE [dbo].[FC_T_CABECERAORDENTRABAJO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERAORDENTRABAJO_FC_T_SERVICIO] FOREIGN KEY([Codigo_Servicio])
REFERENCES [dbo].[FC_T_SERVICIO] ([Codigo_Servicio])
GO
ALTER TABLE [dbo].[FC_T_CABECERAORDENTRABAJO] CHECK CONSTRAINT [FK_FC_T_CABECERAORDENTRABAJO_FC_T_SERVICIO]
GO
ALTER TABLE [dbo].[FC_T_CAJAPOREMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CAJAPOREMPLEADO_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[FC_T_CAJAPOREMPLEADO] CHECK CONSTRAINT [FK_FC_T_CAJAPOREMPLEADO_Empleado]
GO
ALTER TABLE [dbo].[FC_T_CAJAPOREMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CAJAPOREMPLEADO_FC_T_CABECERA_FACTURA] FOREIGN KEY([Codigo_Factura])
REFERENCES [dbo].[FC_T_CABECERA_FACTURA] ([Codigo_Factura])
GO
ALTER TABLE [dbo].[FC_T_CAJAPOREMPLEADO] CHECK CONSTRAINT [FK_FC_T_CAJAPOREMPLEADO_FC_T_CABECERA_FACTURA]
GO
ALTER TABLE [dbo].[FC_T_COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_COTIZACION_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[FC_T_COTIZACION] CHECK CONSTRAINT [FK_FC_T_COTIZACION_Empleado]
GO
ALTER TABLE [dbo].[FC_T_COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_COTIZACION_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[FC_T_COTIZACION] CHECK CONSTRAINT [FK_FC_T_COTIZACION_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[FC_T_COTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_COTIZACION_RH_M_CLIENTE] FOREIGN KEY([Codigo_Cliente])
REFERENCES [dbo].[RH_M_CLIENTE] ([Codigo_Cliente])
GO
ALTER TABLE [dbo].[FC_T_COTIZACION] CHECK CONSTRAINT [FK_FC_T_COTIZACION_RH_M_CLIENTE]
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECAJA_FC_T_CABECERACAJA] FOREIGN KEY([Codigo_CajaPorEmpleado])
REFERENCES [dbo].[FC_T_CABECERACAJA] ([Codigo_Caja])
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJA] CHECK CONSTRAINT [FK_FC_T_DETALLECAJA_FC_T_CABECERACAJA]
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECAJA_FC_T_CAJAPOREMPLEADO] FOREIGN KEY([Codigo_CajaPorEmpleado])
REFERENCES [dbo].[FC_T_CAJAPOREMPLEADO] ([Codigo_CajaPorEmpleado])
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJA] CHECK CONSTRAINT [FK_FC_T_DETALLECAJA_FC_T_CAJAPOREMPLEADO]
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJAPOREMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECAJAPOREMPLEADO_CT_M_MONEDA] FOREIGN KEY([Codigo_Moneda])
REFERENCES [dbo].[CT_M_MONEDA] ([cod_moneda])
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJAPOREMPLEADO] CHECK CONSTRAINT [FK_FC_T_DETALLECAJAPOREMPLEADO_CT_M_MONEDA]
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJAPOREMPLEADO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECAJAPOREMPLEADO_FC_T_CAJAPOREMPLEADO] FOREIGN KEY([Codigo_CajaPorEmpleado])
REFERENCES [dbo].[FC_T_CAJAPOREMPLEADO] ([Codigo_CajaPorEmpleado])
GO
ALTER TABLE [dbo].[FC_T_DETALLECAJAPOREMPLEADO] CHECK CONSTRAINT [FK_FC_T_DETALLECAJAPOREMPLEADO_FC_T_CAJAPOREMPLEADO]
GO
ALTER TABLE [dbo].[FC_T_DETALLECOTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECOTIZACION_FC_T_COTIZACION] FOREIGN KEY([Codigo_Cotizacion])
REFERENCES [dbo].[FC_T_COTIZACION] ([Codigo_Cotizacion])
GO
ALTER TABLE [dbo].[FC_T_DETALLECOTIZACION] CHECK CONSTRAINT [FK_FC_T_DETALLECOTIZACION_FC_T_COTIZACION]
GO
ALTER TABLE [dbo].[FC_T_DETALLECOTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECOTIZACION_IN_M_PRODUCTO] FOREIGN KEY([Codigo_Producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
GO
ALTER TABLE [dbo].[FC_T_DETALLECOTIZACION] CHECK CONSTRAINT [FK_FC_T_DETALLECOTIZACION_IN_M_PRODUCTO]
GO
ALTER TABLE [dbo].[FC_T_DETALLECOTIZACION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLECOTIZACION_Producto] FOREIGN KEY([Codigo_Producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
GO
ALTER TABLE [dbo].[FC_T_DETALLECOTIZACION] CHECK CONSTRAINT [FK_FC_T_DETALLECOTIZACION_Producto]
GO
ALTER TABLE [dbo].[FC_T_DETALLEDEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEDEVOLUCION_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[FC_T_DETALLEDEVOLUCION] CHECK CONSTRAINT [FK_FC_T_DETALLEDEVOLUCION_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[FC_T_DETALLEDEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEDEVOLUCION_FC_T_CABECERADEVOLUCION] FOREIGN KEY([Codigo_Devolucion])
REFERENCES [dbo].[FC_T_CABECERADEVOLUCION] ([Codigo_Devolucion])
GO
ALTER TABLE [dbo].[FC_T_DETALLEDEVOLUCION] CHECK CONSTRAINT [FK_FC_T_DETALLEDEVOLUCION_FC_T_CABECERADEVOLUCION]
GO
ALTER TABLE [dbo].[FC_T_DETALLEDEVOLUCION]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEDEVOLUCION_Producto] FOREIGN KEY([Codigo_Producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
GO
ALTER TABLE [dbo].[FC_T_DETALLEDEVOLUCION] CHECK CONSTRAINT [FK_FC_T_DETALLEDEVOLUCION_Producto]
GO
ALTER TABLE [dbo].[FC_T_DETALLEORDENPAGO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEORDENPAGO_FC_T_CABECERAORDENTRABAJO] FOREIGN KEY([Codigo_OrdenTrabajo])
REFERENCES [dbo].[FC_T_CABECERAORDENTRABAJO] ([Codigo_OrdenTrabajo])
GO
ALTER TABLE [dbo].[FC_T_DETALLEORDENPAGO] CHECK CONSTRAINT [FK_FC_T_DETALLEORDENPAGO_FC_T_CABECERAORDENTRABAJO]
GO
ALTER TABLE [dbo].[FC_T_DETALLEORDENPAGO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEORDENPAGO_RH_M_EMPLEADOPORAREA] FOREIGN KEY([Codigo_Empleado], [Codigo_Area])
REFERENCES [dbo].[RH_M_EMPLEADOPORAREA] ([Codigo_Empleado], [Codigo_Area])
GO
ALTER TABLE [dbo].[FC_T_DETALLEORDENPAGO] CHECK CONSTRAINT [FK_FC_T_DETALLEORDENPAGO_RH_M_EMPLEADOPORAREA]
GO
ALTER TABLE [dbo].[FC_T_PAGOFACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_PAGOFACTURA_FC_T_CABECERA_FACTURA] FOREIGN KEY([Codigo_Factura])
REFERENCES [dbo].[FC_T_CABECERA_FACTURA] ([Codigo_Factura])
GO
ALTER TABLE [dbo].[FC_T_PAGOFACTURA] CHECK CONSTRAINT [FK_FC_T_PAGOFACTURA_FC_T_CABECERA_FACTURA]
GO
ALTER TABLE [dbo].[FC_T_PAGOFACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_PAGOFACTURA_FC_T_FORMAPAGO] FOREIGN KEY([Codigo_FormaPago])
REFERENCES [dbo].[FC_T_FORMAPAGO] ([Codigo_FormaPago])
GO
ALTER TABLE [dbo].[FC_T_PAGOFACTURA] CHECK CONSTRAINT [FK_FC_T_PAGOFACTURA_FC_T_FORMAPAGO]
GO
ALTER TABLE [dbo].[FC_T_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_SERVICIO_FC_T_TIPOSERVICIO] FOREIGN KEY([Codigo_TipoServicio])
REFERENCES [dbo].[FC_T_TIPOSERVICIO] ([Codigo_TipoServicio])
GO
ALTER TABLE [dbo].[FC_T_SERVICIO] CHECK CONSTRAINT [FK_FC_T_SERVICIO_FC_T_TIPOSERVICIO]
GO
ALTER TABLE [dbo].[FC_T_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_SERVICIO_IN_M_EMPLEADO] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[FC_T_SERVICIO] CHECK CONSTRAINT [FK_FC_T_SERVICIO_IN_M_EMPLEADO]
GO
ALTER TABLE [dbo].[FC_T_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_SERVICIO_RH_M_AREADESERVICIO] FOREIGN KEY([Codigo_Area])
REFERENCES [dbo].[RH_M_AREADESERVICIO] ([Codigo_Area])
GO
ALTER TABLE [dbo].[FC_T_SERVICIO] CHECK CONSTRAINT [FK_FC_T_SERVICIO_RH_M_AREADESERVICIO]
GO
ALTER TABLE [dbo].[IN_M_MOVIMIENTO_INVENTARIO]  WITH CHECK ADD  CONSTRAINT [FK_IN_M_MOVIMIENTO_INVENTARIO_IN_M_MOVIMIENTO_INVENTARIO] FOREIGN KEY([CodigoMov_Inventario])
REFERENCES [dbo].[IN_M_MOVIMIENTO_INVENTARIO] ([CodigoMov_Inventario])
GO
ALTER TABLE [dbo].[IN_M_MOVIMIENTO_INVENTARIO] CHECK CONSTRAINT [FK_IN_M_MOVIMIENTO_INVENTARIO_IN_M_MOVIMIENTO_INVENTARIO]
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_CT_T_CABECERA_ASIENTO] FOREIGN KEY([Codigo_Asiento])
REFERENCES [dbo].[CT_T_CABECERA_ASIENTO] ([num_asiento])
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA] CHECK CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_CT_T_CABECERA_ASIENTO]
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_CT_T_TRANSACCION] FOREIGN KEY([Codigo_Transaccion])
REFERENCES [dbo].[CT_T_TRANSACCION] ([cod_transaccion])
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA] CHECK CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_CT_T_TRANSACCION]
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_IN_M_BODEGA] FOREIGN KEY([Codigo_Bodega])
REFERENCES [dbo].[IN_M_BODEGA] ([Codigo_Bodega])
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA] CHECK CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_IN_M_BODEGA]
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_IN_M_EMPLEADO] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[IN_T_CABECERATOMAFISICA] CHECK CONSTRAINT [FK_FC_T_CABECERATOMAFISICA_IN_M_EMPLEADO]
GO
ALTER TABLE [dbo].[IN_T_DETALLE_INGRESOEGRESO]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ingreso_Ingreso] FOREIGN KEY([Codigo_IngresoEgreso])
REFERENCES [dbo].[IN_T_INGRESOEGRESO] ([Codigo_IngresoEgreso])
GO
ALTER TABLE [dbo].[IN_T_DETALLE_INGRESOEGRESO] CHECK CONSTRAINT [FK_Detalle_Ingreso_Ingreso]
GO
ALTER TABLE [dbo].[IN_T_DETALLE_INGRESOEGRESO]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ingreso_Producto] FOREIGN KEY([Codigo_Producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
GO
ALTER TABLE [dbo].[IN_T_DETALLE_INGRESOEGRESO] CHECK CONSTRAINT [FK_Detalle_Ingreso_Producto]
GO
ALTER TABLE [dbo].[IN_T_DETALLE_KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Kardex_Kardex] FOREIGN KEY([Codigo_Kardex])
REFERENCES [dbo].[IN_T_KARDEX] ([Codigo_Kardex])
GO
ALTER TABLE [dbo].[IN_T_DETALLE_KARDEX] CHECK CONSTRAINT [FK_Detalle_Kardex_Kardex]
GO
ALTER TABLE [dbo].[IN_T_DETALLE_KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_IN_T_DETALLE_KARDEX_IN_T_DETALLE_INGRESOEGRESO] FOREIGN KEY([Linea_IngresoEgreso])
REFERENCES [dbo].[IN_T_DETALLE_INGRESOEGRESO] ([Linea_IngresoEgreso])
GO
ALTER TABLE [dbo].[IN_T_DETALLE_KARDEX] CHECK CONSTRAINT [FK_IN_T_DETALLE_KARDEX_IN_T_DETALLE_INGRESOEGRESO]
GO
ALTER TABLE [dbo].[IN_T_DETALLEFISICA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEFISICA_FC_T_CABECERATOMAFISICA] FOREIGN KEY([Codigo_TomaFisica])
REFERENCES [dbo].[IN_T_CABECERATOMAFISICA] ([Codigo_TomaFisica])
GO
ALTER TABLE [dbo].[IN_T_DETALLEFISICA] CHECK CONSTRAINT [FK_FC_T_DETALLEFISICA_FC_T_CABECERATOMAFISICA]
GO
ALTER TABLE [dbo].[IN_T_DETALLEFISICA]  WITH CHECK ADD  CONSTRAINT [FK_FC_T_DETALLEFISICA_IN_M_PRODUCTO] FOREIGN KEY([Codigo_Producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
GO
ALTER TABLE [dbo].[IN_T_DETALLEFISICA] CHECK CONSTRAINT [FK_FC_T_DETALLEFISICA_IN_M_PRODUCTO]
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO] CHECK CONSTRAINT [FK_Ingreso_Empleado]
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Organizacion] FOREIGN KEY([Codigo_Organizacion])
REFERENCES [dbo].[IN_M_ORGANIZACION] ([Codigo_Organizacion])
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO] CHECK CONSTRAINT [FK_Ingreso_Organizacion]
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_TipoDocumento] FOREIGN KEY([Codigo_TipoDocumento])
REFERENCES [dbo].[IN_R_TIPO_DOCUMENTO] ([Codigo_TipoDocumento])
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO] CHECK CONSTRAINT [FK_Ingreso_TipoDocumento]
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_TipoTransaccion] FOREIGN KEY([Codigo_TipoTransaccion])
REFERENCES [dbo].[IN_R_TIPO_TRANSACCION] ([Codigo_TipoTrasanccion])
GO
ALTER TABLE [dbo].[IN_T_INGRESOEGRESO] CHECK CONSTRAINT [FK_Ingreso_TipoTransaccion]
GO
ALTER TABLE [dbo].[IN_T_KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_IN_T_KARDEX_IN_M_PRODUCTO] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[IN_M_PRODUCTO] ([Codigo_Producto])
GO
ALTER TABLE [dbo].[IN_T_KARDEX] CHECK CONSTRAINT [FK_IN_T_KARDEX_IN_M_PRODUCTO]
GO
ALTER TABLE [dbo].[IN_T_KARDEX]  WITH CHECK ADD  CONSTRAINT [FK_Kardex_Empleado] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[IN_T_KARDEX] CHECK CONSTRAINT [FK_Kardex_Empleado]
GO
ALTER TABLE [dbo].[RH_M_AREADESERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_AREADESERVICIO_RH_M_TIPOAREA] FOREIGN KEY([Codigo_TipoArea])
REFERENCES [dbo].[RH_M_TIPOAREA] ([Codigo_TipoArea])
GO
ALTER TABLE [dbo].[RH_M_AREADESERVICIO] CHECK CONSTRAINT [FK_RH_M_AREADESERVICIO_RH_M_TIPOAREA]
GO
ALTER TABLE [dbo].[RH_M_CARGOPORDEPARTAMENTO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_CARGOPORDEPARTAMENTO_IN_M_EMPLEADO] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[RH_M_CARGOPORDEPARTAMENTO] CHECK CONSTRAINT [FK_RH_M_CARGOPORDEPARTAMENTO_IN_M_EMPLEADO]
GO
ALTER TABLE [dbo].[RH_M_CARGOPORDEPARTAMENTO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_CARGOPORDEPARTAMENTO_RH_M_CARGO] FOREIGN KEY([Codigo_Cargo])
REFERENCES [dbo].[RH_M_CARGO] ([Codigo_Cargo])
GO
ALTER TABLE [dbo].[RH_M_CARGOPORDEPARTAMENTO] CHECK CONSTRAINT [FK_RH_M_CARGOPORDEPARTAMENTO_RH_M_CARGO]
GO
ALTER TABLE [dbo].[RH_M_CIUDAD]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_CIUDAD_RH_M_PROVINCIA] FOREIGN KEY([Codigo_Provincia])
REFERENCES [dbo].[RH_M_PROVINCIA] ([Codigo_Provincia])
GO
ALTER TABLE [dbo].[RH_M_CIUDAD] CHECK CONSTRAINT [FK_RH_M_CIUDAD_RH_M_PROVINCIA]
GO
ALTER TABLE [dbo].[RH_M_DEPARTAMENTO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_DEPARTAMENTO_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[RH_M_DEPARTAMENTO] CHECK CONSTRAINT [FK_RH_M_DEPARTAMENTO_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[RH_M_DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_DIRECCION_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[RH_M_DIRECCION] CHECK CONSTRAINT [FK_RH_M_DIRECCION_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[RH_M_DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_DIRECCION_IN_M_EMPLEADO] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[RH_M_DIRECCION] CHECK CONSTRAINT [FK_RH_M_DIRECCION_IN_M_EMPLEADO]
GO
ALTER TABLE [dbo].[RH_M_DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_DIRECCION_RH_M_CLIENTE] FOREIGN KEY([Codigo_Cliente])
REFERENCES [dbo].[RH_M_CLIENTE] ([Codigo_Cliente])
GO
ALTER TABLE [dbo].[RH_M_DIRECCION] CHECK CONSTRAINT [FK_RH_M_DIRECCION_RH_M_CLIENTE]
GO
ALTER TABLE [dbo].[RH_M_DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_DIRECCION_RH_M_PARROQUIA] FOREIGN KEY([Numero_Parroquia])
REFERENCES [dbo].[RH_M_PARROQUIA] ([Numero_Parroquia])
GO
ALTER TABLE [dbo].[RH_M_DIRECCION] CHECK CONSTRAINT [FK_RH_M_DIRECCION_RH_M_PARROQUIA]
GO
ALTER TABLE [dbo].[RH_M_DIRECCION]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_DIRECCION_RH_M_TIPODIRECCION] FOREIGN KEY([Codigo_Tipo_Direccion])
REFERENCES [dbo].[RH_M_TIPODIRECCION] ([Codigo_TipoDireccion])
GO
ALTER TABLE [dbo].[RH_M_DIRECCION] CHECK CONSTRAINT [FK_RH_M_DIRECCION_RH_M_TIPODIRECCION]
GO
ALTER TABLE [dbo].[RH_M_EMPLEADOPORAREA]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_EMPLEADOPORAREA_IN_M_EMPLEADO] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[RH_M_EMPLEADOPORAREA] CHECK CONSTRAINT [FK_RH_M_EMPLEADOPORAREA_IN_M_EMPLEADO]
GO
ALTER TABLE [dbo].[RH_M_EMPLEADOPORAREA]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_EMPLEADOPORAREA_RH_M_AREADESERVICIO] FOREIGN KEY([Codigo_Area])
REFERENCES [dbo].[RH_M_AREADESERVICIO] ([Codigo_Area])
GO
ALTER TABLE [dbo].[RH_M_EMPLEADOPORAREA] CHECK CONSTRAINT [FK_RH_M_EMPLEADOPORAREA_RH_M_AREADESERVICIO]
GO
ALTER TABLE [dbo].[RH_M_PARROQUIA]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_PARROQUIA_RH_M_CIUDAD] FOREIGN KEY([Numero_Ciudad])
REFERENCES [dbo].[RH_M_CIUDAD] ([Numero_Ciudad])
GO
ALTER TABLE [dbo].[RH_M_PARROQUIA] CHECK CONSTRAINT [FK_RH_M_PARROQUIA_RH_M_CIUDAD]
GO
ALTER TABLE [dbo].[RH_M_TELEFONO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_TELEFONO_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[RH_M_TELEFONO] CHECK CONSTRAINT [FK_RH_M_TELEFONO_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[RH_M_TELEFONO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_TELEFONO_IN_M_EMPLEADO] FOREIGN KEY([Codigo_Empleado])
REFERENCES [dbo].[IN_M_EMPLEADO] ([Codigo_Empleado])
GO
ALTER TABLE [dbo].[RH_M_TELEFONO] CHECK CONSTRAINT [FK_RH_M_TELEFONO_IN_M_EMPLEADO]
GO
ALTER TABLE [dbo].[RH_M_TELEFONO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_TELEFONO_RH_M_CLIENTE] FOREIGN KEY([Codigo_Cliente])
REFERENCES [dbo].[RH_M_CLIENTE] ([Codigo_Cliente])
GO
ALTER TABLE [dbo].[RH_M_TELEFONO] CHECK CONSTRAINT [FK_RH_M_TELEFONO_RH_M_CLIENTE]
GO
ALTER TABLE [dbo].[RH_M_TELEFONO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_TELEFONO_RH_M_PROVINCIA] FOREIGN KEY([Codigo_Provincia])
REFERENCES [dbo].[RH_M_PROVINCIA] ([Codigo_Provincia])
GO
ALTER TABLE [dbo].[RH_M_TELEFONO] CHECK CONSTRAINT [FK_RH_M_TELEFONO_RH_M_PROVINCIA]
GO
ALTER TABLE [dbo].[RH_M_TELEFONO]  WITH CHECK ADD  CONSTRAINT [FK_RH_M_TELEFONO_RH_T_TIPOTELEFONO] FOREIGN KEY([Codigo_TipoTelefono])
REFERENCES [dbo].[RH_T_TIPOTELEFONO] ([Codigo_TipoTelefono])
GO
ALTER TABLE [dbo].[RH_M_TELEFONO] CHECK CONSTRAINT [FK_RH_M_TELEFONO_RH_T_TIPOTELEFONO]
GO
ALTER TABLE [dbo].[SG_M_AUDITORIA]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_AUDITORIA_SG_M_OPCIONMENU] FOREIGN KEY([Codigo_OpcionMenu])
REFERENCES [dbo].[SG_M_OPCIONMENU] ([Codigo_OpcionMenu])
GO
ALTER TABLE [dbo].[SG_M_AUDITORIA] CHECK CONSTRAINT [FK_SG_M_AUDITORIA_SG_M_OPCIONMENU]
GO
ALTER TABLE [dbo].[SG_M_AUDITORIA]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_AUDITORIA_SG_M_USUARIO] FOREIGN KEY([Codigo_Usuario])
REFERENCES [dbo].[SG_M_USUARIO] ([Codigo_Usuario])
GO
ALTER TABLE [dbo].[SG_M_AUDITORIA] CHECK CONSTRAINT [FK_SG_M_AUDITORIA_SG_M_USUARIO]
GO
ALTER TABLE [dbo].[SG_M_MODULO]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_MODULO_FC_M_EMPRESA] FOREIGN KEY([Codigo_Empresa])
REFERENCES [dbo].[FC_M_EMPRESA] ([Codigo_Empresa])
GO
ALTER TABLE [dbo].[SG_M_MODULO] CHECK CONSTRAINT [FK_SG_M_MODULO_FC_M_EMPRESA]
GO
ALTER TABLE [dbo].[SG_M_OPCIONMENU]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_OPCIONMENU_SG_M_MODULO] FOREIGN KEY([Codigo_Modulo])
REFERENCES [dbo].[SG_M_MODULO] ([Codigo_Modulo])
GO
ALTER TABLE [dbo].[SG_M_OPCIONMENU] CHECK CONSTRAINT [FK_SG_M_OPCIONMENU_SG_M_MODULO]
GO
ALTER TABLE [dbo].[SG_M_OPCIONMENUPERFIL]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_OPCIONMENUPERFIL_SG_M_OPCIONMENU] FOREIGN KEY([Codigo_OpcionMenu])
REFERENCES [dbo].[SG_M_OPCIONMENU] ([Codigo_OpcionMenu])
GO
ALTER TABLE [dbo].[SG_M_OPCIONMENUPERFIL] CHECK CONSTRAINT [FK_SG_M_OPCIONMENUPERFIL_SG_M_OPCIONMENU]
GO
ALTER TABLE [dbo].[SG_M_OPCIONMENUPERFIL]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_OPCIONMENUPERFIL_SG_M_PERFIL] FOREIGN KEY([Codigo_Perfil])
REFERENCES [dbo].[SG_M_PERFIL] ([Codigo_Perfil])
GO
ALTER TABLE [dbo].[SG_M_OPCIONMENUPERFIL] CHECK CONSTRAINT [FK_SG_M_OPCIONMENUPERFIL_SG_M_PERFIL]
GO
ALTER TABLE [dbo].[SG_M_PANTALLA]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_PANTALLA_SG_M_PANTALLA] FOREIGN KEY([Padre])
REFERENCES [dbo].[SG_M_PANTALLA] ([Codigo_Pantalla])
GO
ALTER TABLE [dbo].[SG_M_PANTALLA] CHECK CONSTRAINT [FK_SG_M_PANTALLA_SG_M_PANTALLA]
GO
ALTER TABLE [dbo].[SG_M_PERFILUSUARIO]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_PERFILUSUARIO_SG_M_PERFIL] FOREIGN KEY([Codigo_Perfil])
REFERENCES [dbo].[SG_M_PERFIL] ([Codigo_Perfil])
GO
ALTER TABLE [dbo].[SG_M_PERFILUSUARIO] CHECK CONSTRAINT [FK_SG_M_PERFILUSUARIO_SG_M_PERFIL]
GO
ALTER TABLE [dbo].[SG_M_PERFILUSUARIO]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_PERFILUSUARIO_SG_M_USUARIO] FOREIGN KEY([Codigo_Usuario])
REFERENCES [dbo].[SG_M_USUARIO] ([Codigo_Usuario])
GO
ALTER TABLE [dbo].[SG_M_PERFILUSUARIO] CHECK CONSTRAINT [FK_SG_M_PERFILUSUARIO_SG_M_USUARIO]
GO
ALTER TABLE [dbo].[SG_M_PRIVILEGIOSUSUARIO]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_PRIVILEGIOSUSUARIO_SG_M_OBJETO] FOREIGN KEY([Codigo_Objeto])
REFERENCES [dbo].[SG_M_OBJETO] ([Codigo_Objeto])
GO
ALTER TABLE [dbo].[SG_M_PRIVILEGIOSUSUARIO] CHECK CONSTRAINT [FK_SG_M_PRIVILEGIOSUSUARIO_SG_M_OBJETO]
GO
ALTER TABLE [dbo].[SG_M_PRIVILEGIOSUSUARIO]  WITH CHECK ADD  CONSTRAINT [FK_SG_M_PRIVILEGIOSUSUARIO_SG_M_USUARIO] FOREIGN KEY([Codigo_Usuario])
REFERENCES [dbo].[SG_M_USUARIO] ([Codigo_Usuario])
GO
ALTER TABLE [dbo].[SG_M_PRIVILEGIOSUSUARIO] CHECK CONSTRAINT [FK_SG_M_PRIVILEGIOSUSUARIO_SG_M_USUARIO]
GO
ALTER TABLE [dbo].[SG_T_OPCIONMENUXBOTON]  WITH CHECK ADD  CONSTRAINT [FK_SG_T_OPCIONMENUXBOTON_SG_M_BOTON] FOREIGN KEY([Codigo_Boton])
REFERENCES [dbo].[SG_M_BOTON] ([Codigo])
GO
ALTER TABLE [dbo].[SG_T_OPCIONMENUXBOTON] CHECK CONSTRAINT [FK_SG_T_OPCIONMENUXBOTON_SG_M_BOTON]
GO
ALTER TABLE [dbo].[SG_T_OPCIONMENUXBOTON]  WITH CHECK ADD  CONSTRAINT [FK_SG_T_OPCIONMENUXBOTON_SG_M_OPCIONMENU] FOREIGN KEY([Codigo_OpcionMenu])
REFERENCES [dbo].[SG_M_OPCIONMENU] ([Codigo_OpcionMenu])
GO
ALTER TABLE [dbo].[SG_T_OPCIONMENUXBOTON] CHECK CONSTRAINT [FK_SG_T_OPCIONMENUXBOTON_SG_M_OPCIONMENU]
GO
/****** Object:  StoredProcedure [dbo].[actualizaperfilusuario]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizaperfilusuario]
	@codper as numeric(4,0),
	@codusu as numeric(4,0)
as
begin
	update SG_M_PERFILUSUARIO set Estado='I' where (Codigo_Perfil=@codper) and (Codigo_Usuario=@codusu)
	--insert into SG_M_PERFILUSUARIO values (@clave,@codper,@codusu,'01-01-15','adm','27-08-20','A')
end
GO
/****** Object:  StoredProcedure [dbo].[botonhabilitados]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[botonhabilitados]
	@cod as numeric(4,0)
as
begin
	select * from SG_T_OPCIONMENUXBOTON where Codigo_OpcionMenu=@cod and Uso=1
end
GO
/****** Object:  StoredProcedure [dbo].[buscarlogin]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscarlogin]
	@login as varchar(50)
as
begin
	select Codigo_Usuario from SG_M_USUARIO where Usuario=@login
end
GO
/****** Object:  StoredProcedure [dbo].[busop]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[busop]
	@nom as varchar(50)
as
begin
	select Codigo_OpcionMenu from SG_M_OPCIONMENU where Opcion_Menu=@nom
end
GO
/****** Object:  StoredProcedure [dbo].[consulta_modulo]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consulta_modulo]
	@cod as numeric(4,0)
as
begin
	select Opcion_Menu from SG_M_OPCIONMENU where Codigo_Modulo=@cod
end

GO
/****** Object:  StoredProcedure [dbo].[consultabusperfil]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultabusperfil]
	@nom as varchar(50)
as
begin
	select Codigo_Perfil from SG_M_PERFIL where Descripcion=@nom
end
GO
/****** Object:  StoredProcedure [dbo].[consultamodulo]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultamodulo]
as
begin
select Descripcion from SG_M_MODULO where Estado='A'
end
GO
/****** Object:  StoredProcedure [dbo].[consultaper]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultaper]
	@cod as numeric(4,0)
as
begin
	select Codigo_Perfil from SG_M_PeRFILUSUARIO where Codigo_Usuario=@cod
end
GO
/****** Object:  StoredProcedure [dbo].[consultaperfil]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultaperfil]
as
begin 
select Descripcion from SG_M_PERFIL
end

GO
/****** Object:  StoredProcedure [dbo].[consultaPerfilMenu]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultaPerfilMenu]
	@cod as numeric(4,0)
as
begin
	select Codigo_OpcionMenu from SG_M_OPCIONMENUPERFIL where Codigo_Perfil=@cod
end
GO
/****** Object:  StoredProcedure [dbo].[consultarlogin]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultarlogin]
as
begin
	select Usuario from SG_M_USUARIO where Estado='A'
end

GO
/****** Object:  StoredProcedure [dbo].[consultausuarioperfil]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[consultausuarioperfil]
	@cod as numeric(4,0)
as
begin 
	select b.Descripcion from SG_M_PERFILUSUARIO a, SG_M_PERFIL b
	where (a.Codigo_Perfil=b.Codigo_Perfil) and (a.Codigo_Usuario=@cod) and Estado='A'
end
GO
/****** Object:  StoredProcedure [dbo].[FC_BUS_EMPLEADO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FC_BUS_EMPLEADO]
as
begin
	select codigo,nombre from FC_M_EMPLEADO
end

GO
/****** Object:  StoredProcedure [dbo].[FC_BUS_MPL]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[FC_BUS_MPL]
	@cod as numeric(4,0)
As
Begin
		Select nombre
		From FC_M_EMPLEADO where codigo=@cod
end

GO
/****** Object:  StoredProcedure [dbo].[FC_IN_AU_INV]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FC_IN_AU_INV]
	@cod as numeric(4,0),
	@val as numeric(3,0)
as
begin
	update IN_M_PRODUCTO set Existencia_Actual=(Existencia_Actual+@val)
	where Codigo_Producto = @cod
end
GO
/****** Object:  StoredProcedure [dbo].[FC_IN_DIS_INV]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FC_IN_DIS_INV]
	@cod as numeric(4,0),
	@val as numeric(3,0)
as
begin
	update IN_M_PRODUCTO set Existencia_Actual=Existencia_Actual-@val
	where Codigo_Producto = @cod
end

GO
/****** Object:  StoredProcedure [dbo].[FC_M_BUS_CLI]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[FC_M_BUS_CLI]
	@cod as numeric(4,0)
As
Begin
		Select Nombre_Cliente
		From RH_M_CLIENTE where Codigo_Cliente=@cod
end

GO
/****** Object:  StoredProcedure [dbo].[FC_M_BUS_F]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[FC_M_BUS_F]
	@cod as numeric(4,0)
As
Begin
		Select Codigo_Empleado
		From FC_T_CABECERA_FACTURA where Codigo_Factura=@cod
end

GO
/****** Object:  StoredProcedure [dbo].[FC_M_BUS_FA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[FC_M_BUS_FA]
	@cod numeric(4,0)
As
Begin
		Select Codigo_Empleado
		From FC_T_CABECERA_FACTURA where Codigo_Factura=@cod
end

GO
/****** Object:  StoredProcedure [dbo].[FC_M_BUS_FAC]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[FC_M_BUS_FAC]
	
As
Begin
		Select Codigo_Factura, a.apellido,b.Apellido_Cliente,Total_Factura
		From FC_T_CABECERA_FACTURA
		inner join FC_M_EMPLEADO a on a.codigo=Codigo_Empleado
		inner join RH_M_CLIENTE b on b.Codigo_Cliente=codigo
		where Estado_Factura='A'
end

GO
/****** Object:  StoredProcedure [dbo].[FC_M_BUS_FACT]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[FC_M_BUS_FACT]
	@cod numeric(4,0)
As
Begin
		Select cod_producto,a.Descripcion_Producto,cantidad,subtotal
		From FC_T_DETALLE_PRODUCTO
		inner join IN_M_PRODUCTO a on a.Codigo_Producto=cod_producto
		where numero_factura=@cod
end

GO
/****** Object:  StoredProcedure [dbo].[FC_T_CAB_PRODUCTOS]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FC_T_CAB_PRODUCTOS]
	@coem as numeric(4,0),
	@cof as numeric(4,0),
	@coe as numeric(4,0),
	@coc as numeric(4,0),
	@fec as date,
	@sub as char(6),
	@iva as char(6),
	@tot as char(6),
	@es as char(1)
as
begin
    declare @Autoincremento numeric(4,0) = (select isnull(MAX(Codigo_Factura),0) from FC_T_CABECERA_FACTURA)+1
	insert into FC_T_CABECERA_FACTURA(Codigo_Factura,Codigo_Empresa,Codigo_Forma_Pago,
	Codigo_Empleado,Codigo_Cliente,Fecha_Factura,Subtotal_Factura,Iva_Factura,Total_Factura,Estado_Factura)
	values (@Autoincremento,@coem,@cof,@coe,@coc,@fec,@sub,@iva,@tot,@es)
end

GO
/****** Object:  StoredProcedure [dbo].[FC_T_COD_FACTURA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FC_T_COD_FACTURA]
	
as
begin
    select Codigo_Factura from FC_T_CABECERA_FACTURA where Codigo_Factura=(select isnull(MAX(Codigo_Factura),0) from FC_T_CABECERA_FACTURA)
end
GO
/****** Object:  StoredProcedure [dbo].[FC_T_DET_PRODUCTOS]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[FC_T_DET_PRODUCTOS]
	@cof as numeric(4,0),
	@sec as numeric(4,0),
	@cop as numeric(4,0),
	@cant as numeric(4,0),
	@sub as char(6)
as
begin
    insert into FC_T_DETALLE_PRODUCTO
	values (@cof,@sec,@cop,@cant,@sub)
end

GO
/****** Object:  StoredProcedure [dbo].[FC_T_ING_ANULACION]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[FC_T_ING_ANULACION]
	@cod as numeric(4,0),
	@fec as date,
	@mot as varchar(50)
as
begin
    declare @Autoincremento numeric(4,0) = (select isnull(MAX(Numero),0) from FC_T_ANULACION)+1
	insert into FC_T_ANULACION
	values (@Autoincremento,@cod,@fec,@mot)
end

GO
/****** Object:  StoredProcedure [dbo].[habilitarperfil]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[habilitarperfil]
	@user as varchar(50)
as
begin
	select Codigo_OpcionMenu from SG_M_OPCIONMENUPERFIL where ((select b.Codigo_Perfil from SG_M_USUARIO a, SG_M_PERFILUSUARIO b where a.Usuario=@user and a.Codigo_Usuario=b.Codigo_Usuario) = Codigo_Perfil)
end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUS_CLIENTE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[IN_M_BUS_CLIENTE]
	
As
Begin
		Select Codigo_Cliente, Nombre_Cliente,Apellido_Cliente, Direccion_Cliente		
		From RH_M_CLIENTE where Estado_Cliente='A'
end

GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUS_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[IN_M_BUS_PRODUCTO]
	
As
Begin
		Select Codigo_Producto, Descripcion_Producto, a.DescripcionTipoProducto, Existencia_Actual, Precio
		From IN_M_PRODUCTO 
		inner join IN_R_TIPO_PRODUCTO a on a.Codigo_TipoProducto=Codigo_TipoProducto
	
end

GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_ESPECIFICA_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_ESPECIFICA_BODEGA]
@codigoBodega integer = null
As
Begin
	If @codigoBodega IS NULL
	BEGIN
		Select *
		From IN_M_BODEGA

	End
	Else
	Begin
		Select *
		From IN_M_BODEGA
		WHERE Codigo_Bodega = @CodigoBodega
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_BODEGA]
@codigoBodega integer = null
As
Begin
	If @codigoBodega IS NULL
	BEGIN
		Select *
		From IN_M_BODEGA

	End
	Else
	Begin
		Select *
		From IN_M_BODEGA
		WHERE Codigo_Bodega = @codigoBodega
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_MEDIDA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_MEDIDA]
@codigoMedida integer = null
As
Begin
	If @codigoMedida IS NULL
	BEGIN
		Select *
		From IN_R_TIPO_MEDIDA

	End
	Else
	Begin
		Select *
		From IN_R_TIPO_MEDIDA
		WHERE Codigo_Medida = @codigoMedida
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_MOVIMIENTO_INVENTARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_MOVIMIENTO_INVENTARIO]
@codigoMov_Inventario integer = null
As
Begin
	If @codigoMov_Inventario IS NULL
	BEGIN
		Select *
		From IN_M_MOVIMIENTO_INVENTARIO

	End
	Else
	Begin
		Select *
		From IN_M_MOVIMIENTO_INVENTARIO
		WHERE CodigoMov_Inventario = @codigoMov_Inventario
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_PERCHA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_PERCHA]
@codigoPercha integer = null
As
Begin
	If @codigoPercha IS NULL
	BEGIN
		Select *
		From IN_M_PERCHA

	End
	Else
	Begin
		Select *
		From IN_M_PERCHA
		WHERE Codigo_Percha = @codigoPercha
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_PRODUCTO]
@codigoProducto integer = null
As
Begin
	If @codigoProducto IS NULL
	BEGIN
		Select *
		From IN_M_PRODUCTO

	End
	Else
	Begin
		Select *
		From IN_M_PRODUCTO
		WHERE Codigo_Producto = @codigoProducto
		end
		end

GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_TIPO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_TIPO_PRODUCTO]
@codigoTipoProducto integer = null
As
Begin
	If @codigoTipoProducto IS NULL
	BEGIN
		Select *
		From IN_R_TIPO_PRODUCTO
	
	End
	Else
	Begin
		Select *
		From IN_R_TIPO_PRODUCTO
		WHERE Codigo_TipoProducto = @codigoTipoProducto
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_TRANSFERENCIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_TRANSFERENCIA]
@codigoTransferencia integer = null
As
Begin
	If @codigoTransferencia IS NULL
	BEGIN
		Select *
		From IN_R_TRANSFERENCIA_INVENTARIO_BODEGA

	End
	Else
	Begin
		Select *
		From IN_R_TRANSFERENCIA_INVENTARIO_BODEGA
		WHERE CodigoTransferenciaInventario = @codigoTransferencia
		end
		end
GO
/****** Object:  StoredProcedure [dbo].[IN_M_EDITAR_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[IN_M_EDITAR_BODEGA]
	@codigoBodega as numeric(4,0) output,
	@descripcionBodega as varchar(40),
	@direccionBodega varchar(40),
	@cantidadPercha as varchar(40),
	@responsableBodega as varchar(30),
	@estado as char(1)

AS
BEGIN
	update IN_M_BODEGA set Descripcion_Bodega = @descripcionBodega, 
	Direccion_Bodega   = @direccionBodega , Cantidad_Percha  = @cantidadPercha,
	Responsable  = @responsableBodega ,Estado = @estado where Codigo_Bodega = @codigoBodega
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_EDITAR_MEDIDA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[IN_M_EDITAR_MEDIDA]
	@codigoMedida as numeric(4,0) output,
	@descripcionMedida varchar(20),
	@estado as char(1)

AS
BEGIN
	update IN_R_TIPO_MEDIDA set Descripcion_Medida= @descripcionMedida, 
	Estado = @estado where Codigo_Medida = @codigoMedida 
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_EDITAR_MOVIMIENTO_INVENTARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[IN_M_EDITAR_MOVIMIENTO_INVENTARIO]
	@codigoMov_Inventario as numeric(4,0) output,
	@tipoDocumento as varchar(30),
	@asociadoA varchar(30),
	@descripcionMovimientoInventario as varchar(30),
	@estado as char(1)

AS
BEGIN
	update IN_M_MOVIMIENTO_INVENTARIO set CodigoMov_Inventario = @codigoMov_Inventario , TipoDocumento = @tipoDocumento, 
	DescripcionMov_Inventario  = @descripcionMovimientoInventario, AsociadoA   = @asociadoA ,
	Estado = @estado where CodigoMov_Inventario = @codigoMov_Inventario
END
 
GO
/****** Object:  StoredProcedure [dbo].[IN_M_EDITAR_PERCHA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[IN_M_EDITAR_PERCHA]
	@codigoPercha as numeric(4,0) output,
	@descripcionPercha as varchar(30),
	@ubicacionPercha varchar(30),
	@cantidadNivelesPercha as varchar(10),
	@estado as char(1)

AS
BEGIN
	update IN_M_PERCHA set Descripcion_Percha = @descripcionPercha, 
	UbicacionPercha  = @ubicacionPercha , Cantidad_NivelesPercha  = @cantidadNivelesPercha,
	Estado = @estado where Codigo_Percha = @codigoPercha
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_EDITAR_TIPO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[IN_M_EDITAR_TIPO_PRODUCTO]
	@codigoTipoProducto as numeric(4,0) output,
	@descripcionTipoProducto as varchar(20),
	@estado as char(1)

AS
BEGIN
	update IN_R_TIPO_PRODUCTO set DescripcionTipoProducto = @descripcionTipoProducto, 
	Estado = @estado where Codigo_TipoProducto = @codigoTipoProducto 
END

GO
/****** Object:  StoredProcedure [dbo].[IN_M_EDITAR_TRANSFERENCIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[IN_M_EDITAR_TRANSFERENCIA]
	@codigoTransferencia as numeric(4,0) output,
	@bodegaSaliente as varchar(20),
	@bodegaEntrante varchar(20),
	@responsable as varchar(20),
	@motivo as varchar(60),
	@estado as char(1)

AS
BEGIN
	update IN_R_TRANSFERENCIA_INVENTARIO_BODEGA set @bodegaSaliente = @bodegaSaliente, 
	BodegaEntrante   = @bodegaEntrante , ResponsableBodega  = @responsable,
	EstadoTransferencia = @estado where CodigoTransferenciaInventario = @codigoTransferencia
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_ELIMINAR_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_BODEGA]
	@codigoBodega as numeric(4,0)
AS
BEGIN
	update IN_M_BODEGA set Estado='I' where Codigo_Bodega=@codigoBodega
END

GO
/****** Object:  StoredProcedure [dbo].[IN_M_ELIMINAR_MEDIDA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[IN_M_ELIMINAR_MEDIDA]
	@codigoMedida as numeric(4,0)
AS
BEGIN
	update IN_R_TIPO_MEDIDA set Estado ='I' where Codigo_Medida = @codigoMedida
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_ELIMINAR_MOVIMIENTO_INVENTARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_MOVIMIENTO_INVENTARIO]
	@codigoMov_Inventario as numeric(4,0)
AS
BEGIN
	update IN_M_MOVIMIENTO_INVENTARIO set Estado='I' where CodigoMov_Inventario = @codigoMov_Inventario
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_ELIMINAR_PERCHA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_PERCHA]
	@codigoPercha as numeric(4,0)
AS
BEGIN
	update IN_M_PERCHA set Estado='I' where Codigo_Percha=@codigoPercha
END

GO
/****** Object:  StoredProcedure [dbo].[IN_M_ELIMINAR_TIPO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_TIPO_PRODUCTO]
	@codigoTipoProducto as numeric(4,0)
AS
BEGIN
	update IN_R_TIPO_PRODUCTO set Estado ='I' where Codigo_TipoProducto=@codigoTipoProducto
END
GO
/****** Object:  StoredProcedure [dbo].[IN_M_ELIMINAR_TRANSFERENCIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_TRANSFERENCIA]
	@codigoTransferencia as numeric(4,0)
AS
BEGIN
	update IN_R_TRANSFERENCIA_INVENTARIO_BODEGA set EstadoTransferencia ='I' where CodigoTransferenciaInventario = @codigoTransferencia
END
GO
/****** Object:  StoredProcedure [dbo].[ingresoperfilmenu]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ingresoperfilmenu]
	@codper as numeric(4,0),
	@codop as numeric(4,0)
as
begin
	declare @clave numeric(4,0) = (select isnull(MAX(Codigo_OpcionPerfil),0) from SG_M_OPCIONMENUPERFIL)+1
	insert into SG_M_OPCIONMENUPERFIL values (@clave,@codper,@codop,'01-01-15','27-08-20','adm','A')
end

GO
/****** Object:  StoredProcedure [dbo].[ingresoperfilusuario]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ingresoperfilusuario]
	@codper as numeric(4,0),
	@codusu as numeric(4,0)
as
begin
	declare @clave numeric(4,0) = (select isnull(MAX(Codigo_PerfilUsuario),0) from SG_M_PERFILUSUARIO)+1
	insert into SG_M_PERFILUSUARIO values (@clave,@codper,@codusu,'01-01-15','adm','27-08-20','A')
end

GO
/****** Object:  StoredProcedure [dbo].[ingresorol]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ingresorol]
	@cla as int,
	@des as varchar(100),
	@fec as datetime
as
begin
	insert into SG_M_PERFIL values(@cla,@des,@fec,'adm',GETDATE())
end
GO
/****** Object:  StoredProcedure [dbo].[IngresoSistema]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[IngresoSistema]
	@usu as varchar(50),
	@pas as varchar(50)
as
begin
	select ISNULL(Codigo_Usuario,0) from SG_M_USUARIO where Usuario=@usu
	and Pasword=@pas
end
GO
/****** Object:  StoredProcedure [dbo].[ingresousuario]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ingresousuario]
	@code as numeric(4,0),
	@user as varchar(50),
	@pas as varchar(100),
	@fec as datetime
as
begin
	declare @clave numeric(4,0) = (select isnull(MAX(Codigo_Usuario),0) from SG_M_USUARIO)+1
	insert into SG_M_USUARIO values(@clave,@code,1,@user,@pas,@fec,'A')
end

GO
/****** Object:  StoredProcedure [dbo].[SV_FC_CONSULTAR_CLIENTE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_FC_CONSULTAR_CLIENTE]
	@cod as numeric(4,0)
AS
BEGIN
	select RUC_Cliente,Cedula_Cliente, RazonSocial_Cliente,Nombre_Cliente,
	Apellido_Cliente,Direccion_Cliente,Telefono_Cliente,Genero_Cliente, Estado_Cliente from RH_M_CLIENTE where Codigo_Cliente=@cod
END

GO
/****** Object:  StoredProcedure [dbo].[SV_FC_CONSULTAR_PERCHA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_FC_CONSULTAR_PERCHA]
	@CodigoPercha as numeric(4,0)
AS
BEGIN
	select Codigo_Percha,Descripcion_Percha,UbicacionPercha,Cantidad_NivelesPercha,Estado from IN_M_PERCHA
	where Codigo_Percha=@CodigoPercha
END
GO
/****** Object:  StoredProcedure [dbo].[SV_FC_CONSULTAR_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SV_FC_CONSULTAR_PRODUCTO]
	@CodigoProducto as numeric(4,0)
AS
BEGIN
	select Codigo_Producto, Descripcion_Producto,Codigo_TipoProducto,Codigo_Seccion,Codigo_TipoUnidad,
	Existencia_Actual,Stock_Minimo,Stock_Maximo,Costo,Precio,Estado from IN_M_PRODUCTO
	where Codigo_Producto=@CodigoProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SV_FC_CONSULTAR_TIPO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SV_FC_CONSULTAR_TIPO_PRODUCTO]
	@CodigoTipoProducto as numeric(4,0)
AS
BEGIN
	select Codigo_TipoProducto,DescripcionTipoProducto,Estado from IN_R_TIPO_PRODUCTO
	where Codigo_TipoProducto=@CodigoTipoProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SV_FC_CONSULTAR_TRANSFERENCIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SV_FC_CONSULTAR_TRANSFERENCIA]
	@codigoTransferencia as numeric(4,0)
AS
BEGIN
	select CodigoTransferenciaInventario, BodegaSaliente, BodegaEntrante, ResponsableBodega, Motivo, EstadoTransferencia
	from IN_R_TRANSFERENCIA_INVENTARIO_BODEGA where CodigoTransferenciaInventario=@codigoTransferencia
END

GO
/****** Object:  StoredProcedure [dbo].[SV_FC_ELIMINAR_CLIENTE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_FC_ELIMINAR_CLIENTE]
	@cod as numeric(4,0)
AS
BEGIN
	update RH_M_CLIENTE set Estado_Cliente='I' where Codigo_Cliente=@cod
END

GO
/****** Object:  StoredProcedure [dbo].[SV_FC_ELIMINAR_FACTURA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_FC_ELIMINAR_FACTURA]
	@cod as numeric(4,0)
AS
BEGIN
	update FC_T_CABECERA_FACTURA set Estado_Factura='I' where Codigo_Factura=@cod
END

GO
/****** Object:  StoredProcedure [dbo].[SV_FC_INGRESO_CLIENTE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_FC_INGRESO_CLIENTE]
	@cod as numeric(4,0),
	@ruc as numeric(13,0),
	@id as numeric(10,0),
	@razon as varchar(40),
	@nomb as varchar(40),
	@ape as varchar(40),
	@dir as varchar(50),
	@tel as numeric(10),
	@gen as char(1),
	@est as char(1)
AS
BEGIN
	insert into RH_M_CLIENTE(Codigo_Cliente,RUC_Cliente, Cedula_Cliente,RazonSocial_Cliente,Nombre_Cliente,
	Apellido_Cliente,Direccion_Cliente,Telefono_Cliente,Genero_Cliente, Estado_Cliente)values(@cod,@ruc,
	@id,@razon,@nomb,@ape,@dir,@tel,@gen,@est)
END

GO
/****** Object:  StoredProcedure [dbo].[SV_FC_MODIFICAR_CLIENTE]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_FC_MODIFICAR_CLIENTE]
	@cod as numeric(4,0),
	@ruc as numeric(13,0),
	@id as numeric(10,0),
	@razon as varchar(40),
	@nomb as varchar(40),
	@ape as varchar(40),
	@dir as varchar(50),
	@tel as numeric(10),
	@gen as char(1),
	@est as char(1)
AS
BEGIN
	update RH_M_CLIENTE set RUC_Cliente=@ruc, Cedula_Cliente=@id,RazonSocial_Cliente=@razon,
	Nombre_Cliente=@nomb,Apellido_Cliente=@ape,Direccion_Cliente=@dir,Telefono_Cliente=@tel,
	Genero_Cliente=@gen, Estado_Cliente=@est where Codigo_Cliente=@cod
END

GO
/****** Object:  StoredProcedure [dbo].[SV_IN_EDITAR_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SV_IN_EDITAR_PRODUCTO]
	@cod as numeric(4,0),
	@des as varchar(20),
	@codP as numeric(4,0),
	@codS as numeric(4,0),
	@codU as numeric(4,0),
	@exis as numeric(3,0),
	@stoMa as numeric(3,0),
	@stoMi as numeric(3,0),
	@cos as numeric(4,2),
	@pre as numeric(4,2),
	@est as char(1)
AS
BEGIN
	update IN_M_PRODUCTO set Descripcion_Producto=@des,Codigo_TipoProducto=@codP,Codigo_Seccion=@codS,Codigo_TipoUnidad=@codU,
	Existencia_Actual=@exis,Stock_Minimo=@stoMi,Stock_Maximo=@stoMa,Costo=@cos,Precio=@pre,Estado=@est where Codigo_Producto=@cod
END

GO
/****** Object:  StoredProcedure [dbo].[SV_IN_ELIMINAR_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SV_IN_ELIMINAR_PRODUCTO]
	@cod as numeric(4,0)
AS
BEGIN
	update IN_M_PRODUCTO set Estado='I' where Codigo_Producto=@cod
END

GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_BODEGA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SV_IN_INGRESAR_BODEGA]
	@descripcionBodega as varchar(40),
	@direccionBodega varchar(40),
	@cantidadPercha as varchar(40),
	@responsableBodega as varchar(30),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_M_BODEGA(Descripcion_Bodega, Direccion_Bodega, 
	Cantidad_Percha, Responsable,Estado ) 
	values( @descripcionBodega, @direccionBodega, @cantidadPercha, 
	@responsableBodega, @estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_MEDIDA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SV_IN_INGRESAR_MEDIDA]
	@descripcionMedida as varchar(20),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_R_TIPO_MEDIDA(Descripcion_Medida,Estado ) 
	values(@descripcionMedida,@estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_MOVIMIENTO_INVENTARIO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SV_IN_INGRESAR_MOVIMIENTO_INVENTARIO]
	@codigoMov_Inventario as numeric(4,0) output,
	@tipoDocumento as varchar(30),
	@asociadoA varchar(30),
	@descripcionMovimientoInventario as varchar(30),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_M_MOVIMIENTO_INVENTARIO(CodigoMov_Inventario,TipoDocumento, DescripcionMov_Inventario, 
	AsociadoA, Estado) 
	values(@codigoMov_Inventario, @tipoDocumento, @descripcionMovimientoInventario,@asociadoA, @estado)
set @codigoMov_Inventario = @@IDENTITY 
END
GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_PERCHA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SV_IN_INGRESAR_PERCHA]
	@descripcionPercha as varchar(30),
	@ubicacionPercha varchar(30),
	@cantidadNivelesPercha as varchar(10),
	@estado as char(1)
AS
BEGIN
	INSERT INTO IN_M_PERCHA(Descripcion_Percha, UbicacionPercha, 
	Cantidad_NivelesPercha,Estado ) 
	values(@descripcionPercha, @ubicacionPercha, @cantidadNivelesPercha, 
	@estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SV_IN_INGRESAR_PRODUCTO]
	@descripcionProducto as varchar(20),
	@tipoProducto as varchar(30),
	@medida as varchar(30),
	@bodega as varchar(30),
	@percha as varchar(30),
	@existenciaActual as numeric(3,0), 
	@stockMinimo as numeric(3,0),
	@stockMaximo as numeric(3,0),
	@costo as numeric(4,2),
	@precio as numeric(4,2),
	@estado as char(1)
AS
BEGIN
	insert into IN_M_PRODUCTO(Descripcion_Producto,Tipo_Producto,Medida,Bodega,Percha,Existencia_Actual,
	Stock_Minimo,Stock_Maximo,Costo,Precio,Estado)values(@descripcionProducto, 
	@tipoProducto,@medida,@bodega,@percha,@existenciaActual,@stockMinimo,@stockMaximo,
	@costo,@precio,@estado)
END
GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_TIPO_PRODUCTO]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SV_IN_INGRESAR_TIPO_PRODUCTO]
	@descripcionTipoProducto as varchar(20),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_R_TIPO_PRODUCTO(DescripcionTipoProducto,Estado ) 
	values(@descripcionTipoProducto,@estado)

END
GO
/****** Object:  StoredProcedure [dbo].[SV_IN_INGRESAR_TRANSFERENCIA]    Script Date: 03/08/2015 13:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SV_IN_INGRESAR_TRANSFERENCIA]
	@bodegaSaliente as varchar(20),
	@bodegaEntrante varchar(20),
	@responsable as varchar(20),
	@motivo as varchar(60),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_R_TRANSFERENCIA_INVENTARIO_BODEGA(BodegaSaliente, BodegaEntrante, ResponsableBodega,
	Motivo,EstadoTransferencia) 
	values( @bodegaSaliente,@bodegaEntrante,@responsable,@motivo, @estado)
END
GO
