USE [PAV1]
GO
/****** Object:  Table [dbo].[Barrio]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrio](
	[codBarrio] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codLocalidad] [int] NOT NULL,
 CONSTRAINT [PK_Barrio] PRIMARY KEY CLUSTERED 
(
	[codBarrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[cuitCliente] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[activo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[cuitCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cotizaciones]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizaciones](
	[numeroCotizacion] [int] NOT NULL,
	[año] [int] NOT NULL,
	[cuitCliente] [varchar](50) NOT NULL,
	[tipoDocVendedor] [int] NOT NULL,
	[numDocVendedor] [int] NOT NULL,
	[codEstadoCotizacion] [int] NOT NULL,
	[nombreSolicitante] [varchar](50) NOT NULL,
	[apellidoSolicitante] [varchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
	[observaciones] [varchar](50) NOT NULL,
	[precioTotal] [float] NOT NULL,
	[motivoPerdida] [varchar](50) NOT NULL,
	[nomCompetidor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cotizaciones1] PRIMARY KEY CLUSTERED 
(
	[numeroCotizacion] ASC,
	[año] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCotizacion]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCotizacion](
	[numeroCotizacion] [int] NOT NULL,
	[año] [int] NOT NULL,
	[codProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
 CONSTRAINT [PK_DetalleCotizacion1] PRIMARY KEY CLUSTERED 
(
	[numeroCotizacion] ASC,
	[año] ASC,
	[codProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[numeroDetalleFactura] [int] NOT NULL,
	[numFactura] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioUnitario] [float] NOT NULL,
	[codProducto] [int] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[numeroDetalleFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[numeroPedido] [int] NOT NULL,
	[codigoProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[numeroPedido] ASC,
	[codigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleProducto]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleProducto](
	[codProductoComponente] [int] NOT NULL,
	[codProductoGenerico] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_DetalleProducto1] PRIMARY KEY CLUSTERED 
(
	[codProductoComponente] ASC,
	[codProductoGenerico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[tipoDoc] [int] NOT NULL,
	[numDoc] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[codBarrio] [int] NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[tipoDocJefe] [int] NULL,
	[numDocJefe] [int] NULL,
	[activo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleados1] PRIMARY KEY CLUSTERED 
(
	[numDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosCotizaciones]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosCotizaciones](
	[codEstado] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadosCotizaciones] PRIMARY KEY CLUSTERED 
(
	[codEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[numeroFactura] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[tipoFactura] [int] NOT NULL,
	[numDocEmpleado] [int] NOT NULL,
	[cuil] [int] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[numeroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[codLocalidad] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codProvincia] [int] NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[codLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[numeroPedido] [int] NOT NULL,
	[numeroCotizacion] [int] NOT NULL,
	[fechaPedido] [date] NOT NULL,
	[tipoDniVendedor] [int] NOT NULL,
	[numDniVendedor] [int] NOT NULL,
	[condicionPago] [varchar](50) NOT NULL,
	[cuitCliente] [varchar](50) NOT NULL,
	[añoCotizacion] [int] NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[numeroPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[codProducto] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[cantStock] [int] NOT NULL,
	[cuitProveedor] [varchar](50) NOT NULL,
	[codProductoEq] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[codProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[cuitProveedor] [varchar](50) NOT NULL,
	[razonSocial] [varchar](50) NOT NULL,
	[contacto] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[activo] [bit] DEFAULT ((1)) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[cuitProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[codProvincia] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[codProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDoc]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDoc](
	[idTipoDoc] [int] NOT NULL,
	[siglas] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposDoc] PRIMARY KEY CLUSTERED 
(
	[idTipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/9/2022 17:06:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](30) NULL,
	[Password] [nchar](30) NULL,
	[Email] [nchar](30) NULL,
	[id_Perfil] [int] NULL,
	[Activo] [bit] DEFAULT ((1))NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Barrio]  WITH CHECK ADD  CONSTRAINT [FK_Barrio_Localidad] FOREIGN KEY([codLocalidad])
REFERENCES [dbo].[Localidad] ([codLocalidad])
GO
ALTER TABLE [dbo].[Barrio] CHECK CONSTRAINT [FK_Barrio_Localidad]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_codEstado_Cotizacion] FOREIGN KEY([codEstadoCotizacion])
REFERENCES [dbo].[EstadosCotizaciones] ([codEstado])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_codEstado_Cotizacion]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cotizacion_Cliente] FOREIGN KEY([cuitCliente])
REFERENCES [dbo].[Cliente] ([cuitCliente])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_Cotizacion_Cliente]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cotizaciones_Vendedor] FOREIGN KEY([tipoDocVendedor])
REFERENCES [dbo].[TiposDoc] ([idTipoDoc])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_Cotizaciones_Vendedor]
GO
ALTER TABLE [dbo].[Cotizaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cotizaciones_VendedorNumDni] FOREIGN KEY([numDocVendedor])
REFERENCES [dbo].[Empleados] ([numDoc])
GO
ALTER TABLE [dbo].[Cotizaciones] CHECK CONSTRAINT [FK_Cotizaciones_VendedorNumDni]
GO
ALTER TABLE [dbo].[DetalleCotizacion]  WITH CHECK ADD  CONSTRAINT [FK_Cotizacion_Detalle] FOREIGN KEY([numeroCotizacion], [año])
REFERENCES [dbo].[Cotizaciones] ([numeroCotizacion], [año])
GO
ALTER TABLE [dbo].[DetalleCotizacion] CHECK CONSTRAINT [FK_Cotizacion_Detalle]
GO
ALTER TABLE [dbo].[DetalleCotizacion]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Producto] FOREIGN KEY([codProducto])
REFERENCES [dbo].[Productos] ([codProducto])
GO
ALTER TABLE [dbo].[DetalleCotizacion] CHECK CONSTRAINT [FK_Detalle_Producto]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Factura] FOREIGN KEY([numFactura])
REFERENCES [dbo].[Factura] ([numeroFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Factura]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Productos] FOREIGN KEY([codProducto])
REFERENCES [dbo].[Productos] ([codProducto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Productos]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Detalle] FOREIGN KEY([numeroPedido])
REFERENCES [dbo].[Pedidos] ([numeroPedido])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_Pedido_Detalle]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Detalle] FOREIGN KEY([codigoProducto])
REFERENCES [dbo].[Productos] ([codProducto])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_Producto_Detalle]
GO
ALTER TABLE [dbo].[DetalleProducto]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCmp_Producto] FOREIGN KEY([codProductoComponente])
REFERENCES [dbo].[Productos] ([codProducto])
GO
ALTER TABLE [dbo].[DetalleProducto] CHECK CONSTRAINT [FK_DetalleCmp_Producto]
GO
ALTER TABLE [dbo].[DetalleProducto]  WITH CHECK ADD  CONSTRAINT [FK_DetalleGenerico_Producto] FOREIGN KEY([codProductoGenerico])
REFERENCES [dbo].[Productos] ([codProducto])
GO
ALTER TABLE [dbo].[DetalleProducto] CHECK CONSTRAINT [FK_DetalleGenerico_Producto]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadonumDoc_Empleado] FOREIGN KEY([numDocJefe])
REFERENCES [dbo].[Empleados] ([numDoc])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_EmpleadonumDoc_Empleado]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Barrio] FOREIGN KEY([codBarrio])
REFERENCES [dbo].[Barrio] ([codBarrio])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Barrio]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoTipoDoc_Empleado] FOREIGN KEY([tipoDocJefe])
REFERENCES [dbo].[TiposDoc] ([idTipoDoc])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_EmpleadoTipoDoc_Empleado]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_TipoDoc_Empleados] FOREIGN KEY([tipoDoc])
REFERENCES [dbo].[TiposDoc] ([idTipoDoc])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_TipoDoc_Empleados]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Provincia_Localidad] FOREIGN KEY([codProvincia])
REFERENCES [dbo].[Provincia] ([codProvincia])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Provincia_Localidad]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([cuitCliente])
REFERENCES [dbo].[Cliente] ([cuitCliente])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cotizacion] FOREIGN KEY([numeroCotizacion], [añoCotizacion])
REFERENCES [dbo].[Cotizaciones] ([numeroCotizacion], [año])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedido_Cotizacion]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_numDocVendedor] FOREIGN KEY([numDniVendedor])
REFERENCES [dbo].[Empleados] ([numDoc])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedido_numDocVendedor]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_tipoDocVendedor] FOREIGN KEY([tipoDniVendedor])
REFERENCES [dbo].[TiposDoc] ([idTipoDoc])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedido_tipoDocVendedor]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Productos] FOREIGN KEY([codProducto])
REFERENCES [dbo].[Productos] ([codProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Productos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Proveedor] FOREIGN KEY([cuitProveedor])
REFERENCES [dbo].[Proveedor] ([cuitProveedor])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Proveedor]
GO
INSERT INTO Usuarios(UserName, Password, Email, id_Perfil)
Values('ADMIN','1234','T',1)
