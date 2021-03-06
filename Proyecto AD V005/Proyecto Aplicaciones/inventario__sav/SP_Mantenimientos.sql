USE [SAV]
GO
/****** Object:  StoredProcedure [dbo].[IN_M_BUSQUEDA_GENERAL_BODEGA]    Script Date: 13/08/2014 05:08:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--BUSQUEDAS GENERALES

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

		CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_MEDIDA]
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

		CREATE PROCEDURE [dbo].[IN_M_BUSQUEDA_GENERAL_PERCHA]
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



	--PROCEDIMIENTOS DE MODIFICACION

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


CREATE procedure [dbo].[IN_M_EDITAR_MEDIDA]
	@codigoMedida as numeric(4,0) output,
	@descripcionMedida varchar(20),
	@estado as char(1)

AS
BEGIN
	update IN_R_TIPO_MEDIDA set Descripcion_Medida= @descripcionMedida, 
	Estado = @estado where Codigo_Medida = @codigoMedida 
END

CREATE procedure [dbo].[IN_M_EDITAR_MOVIMIENTO_INVENTARIO]
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

CREATE procedure [dbo].[IN_M_EDITAR_TIPO_PRODUCTO]
	@codigoTipoProducto as numeric(4,0) output,
	@descripcionTipoProducto as varchar(20),
	@estado as char(1)

AS
BEGIN
	update IN_R_TIPO_PRODUCTO set DescripcionTipoProducto = @descripcionTipoProducto, 
	Estado = @estado where Codigo_TipoProducto = @codigoTipoProducto 
END


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


	-- PROCEDIMIENTOS DE ELIMINACION

	CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_BODEGA]
	@codigoBodega as numeric(4,0)
AS
BEGIN
	update IN_M_BODEGA set Estado='I' where Codigo_Bodega=@codigoBodega
END


CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_MEDIDA]
	@codigoMedida as numeric(4,0)
AS
BEGIN
	update IN_R_TIPO_MEDIDA set Estado ='I' where Codigo_Medida = @codigoMedida
END


CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_MOVIMIENTO_INVENTARIO]
	@codigoMov_Inventario as numeric(4,0)
AS
BEGIN
	update IN_M_MOVIMIENTO_INVENTARIO set Estado='I' where CodigoMov_Inventario = @codigoMov_Inventario
END


CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_PERCHA]
	@codigoPercha as numeric(4,0)
AS
BEGIN
	update IN_M_PERCHA set Estado='I' where Codigo_Percha=@codigoPercha
END


CREATE PROCEDURE [dbo].[IN_M_ELIMINAR_TIPO_PRODUCTO]
	@codigoTipoProducto as numeric(4,0)
AS
BEGIN
	update IN_R_TIPO_PRODUCTO set Estado ='I' where Codigo_TipoProducto=@codigoTipoProducto
END


CREATE PROCEDURE [dbo].[SV_IN_ELIMINAR_PRODUCTO]
	@cod as numeric(4,0)
AS
BEGIN
	update IN_M_PRODUCTO set Estado='I' where Codigo_Producto=@cod
END



	--PROCEDIMIENTOS DE CONSULTA ESPECIFICA

	CREATE PROCEDURE [dbo].[SV_FC_CONSULTAR_PERCHA]
	@CodigoPercha as numeric(4,0)
AS
BEGIN
	select Codigo_Percha,Descripcion_Percha,UbicacionPercha,Cantidad_NivelesPercha,Estado from IN_M_PERCHA
	where Codigo_Percha=@CodigoPercha
END


CREATE PROCEDURE [dbo].[SV_FC_CONSULTAR_PRODUCTO]
	@CodigoProducto as numeric(4,0)
AS
BEGIN
	select Codigo_Producto, Descripcion_Producto,Codigo_TipoProducto,Codigo_Seccion,Codigo_TipoUnidad,
	Existencia_Actual,Stock_Minimo,Stock_Maximo,Costo,Precio,Estado from IN_M_PRODUCTO
	where Codigo_Producto=@CodigoProducto
END


CREATE PROCEDURE [dbo].[SV_FC_CONSULTAR_TIPO_PRODUCTO]
	@CodigoTipoProducto as numeric(4,0)
AS
BEGIN
	select Codigo_TipoProducto,DescripcionTipoProducto,Estado from IN_R_TIPO_PRODUCTO
	where Codigo_TipoProducto=@CodigoTipoProducto
END

	--PROCEDIMIENTOS DE INGRESO

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


CREATE procedure [dbo].[SV_IN_INGRESAR_MEDIDA]
	@descripcionMedida as varchar(20),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_R_TIPO_MEDIDA(Descripcion_Medida,Estado ) 
	values(@descripcionMedida,@estado)
END


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


CREATE procedure [dbo].[SV_IN_INGRESAR_TIPO_PRODUCTO]
	@descripcionTipoProducto as varchar(20),
	@estado as char(1)
AS
BEGIN
	

	INSERT INTO IN_R_TIPO_PRODUCTO(DescripcionTipoProducto,Estado ) 
	values(@descripcionTipoProducto,@estado)

END