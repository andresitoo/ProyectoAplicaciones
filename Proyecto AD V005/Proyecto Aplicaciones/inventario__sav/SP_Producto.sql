
create procedure [dbo].[SV_IN_INGRESAR_PRODUCTO]
	@codigoProducto as numeric(4,0) output,
	@descripcionProducto as varchar(30),
	@codigoTipoProducto as numeric(4,0),
	@codigoSeccion as numeric(4,0),
	@codigoTipoUnidad as numeric(4,0),
	@existenciaActual as numeric(2,0),
	@stockMinimo as numeric(2,0),
	@stockMaximo as numeric(2,0),
	@costo as numeric(4,2),
	@precio as numeric(4,2),
	@estado as numeric(4,0)
AS
BEGIN
	

	INSERT INTO IN_M_PRODUCTO(Codigo_Producto,Descripcion_Producto, Codigo_TipoProducto, 
	Codigo_Seccion, Codigo_TipoUnidad,ExistenciaActual, Stock_Minimo, Stock_Maximo, Costo, Precio,Estado ) 
	values(@codigoProducto, @descripcionProducto, @codigoTipoProducto, @codigoSeccion, 
	@codigoTipoUnidad, @existenciaActual, @stockMinimo, @stockMaximo,@costo, @precio, @estado)
set @codigoProducto = @@IDENTITY 
END


create procedure [dbo].[IN_M_EDITAR_PRODUCTO]
	@codigoProducto as numeric(4,0),
	@descripcionProducto as varchar(30),
	@codigoTipoProducto as numeric(4,0),
	@codigoSeccion as numeric(4,0),
	@codigoTipoUnidad as numeric(4,0),
	@existenciaActual as numeric(2,0),
	@stockMinimo as numeric(2,0),
	@stockMaximo as numeric(2,0),
	@costo as numeric(4,2),
	@precio as numeric(4,2),
	@estado as numeric(4,2)

AS
BEGIN
	update IN_M_PRODUCTO set Descripcion_Producto = @descripcionProducto , Codigo_TipoProducto = @codigoTipoProducto , 
	Codigo_Seccion   = @codigoSeccion , Codigo_TipoUnidad  = @codigoTipoUnidad ,
	ExistenciaActual  = @existenciaActual , Stock_Minimo  = @stockMinimo , 
	Stock_Maximo = @stockMaximo , Costo = @costo , Precio = @precio ,Estado = @estado where Codigo_Producto=@codigoProducto
END
GO

CREATE PROCEDURE IN_M_ELIMINAR_PRODUCTO
	@codigoProducto as numeric(4,0)
AS
BEGIN
	update IN_M_PRODUCTO set Estado='I' where Codigo_Producto=@codigoProducto
END
GO

CREATE PROCEDURE IN_M_BUSQUEDA_ESPECIFICA_PRODUCTO
@CodigoProducto integer = null
As
Begin
	If @CodigoProducto IS NULL
	BEGIN
		Select *
		From IN_M_PRODUCTO

	End
	Else
	Begin
		Select *
		From IN_M_PRODUCTO
		WHERE Codigo_Producto = @CodigoProducto
		end
		end
