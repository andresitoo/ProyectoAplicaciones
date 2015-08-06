--******** pruebas
select * from SG_M_PERFIL
select * from SG_M_OPCIONMENU
select Codigo_OpcionMenu from SG_M_OPCIONMENUPERFIL where ((select b.Codigo_Perfil from SG_M_USUARIO a, SG_M_PERFILUSUARIO b where a.Usuario='aede' and a.Codigo_Usuario=b.Codigo_Usuario) = Codigo_Perfil)
select * from SG_M_OPCIONMENUPERFIL
select b.Codigo_Perfil from SG_M_USUARIO a, SG_M_PERFILUSUARIO b where a.Usuario='aede' and a.Codigo_Usuario=b.Codigo_Usuario
select * from SG_M_PERFILUSUARIO
select * from SG_M_PERFIL
use SAV
--**********************
select * from FC_M_EMPLEADO
delete from FC_M_EMPLEADO
--insert FC_M_EMPLEADO
insert into FC_M_empleado values(1,'Juan','Vera',98989898,222222,'Cementerio','Administrador',
'1990-08-08','2014-08-08','A')
insert into FC_M_empleado values(2,'Andres','Morales',98457120,456895,'Centro','Seguridad',
'1990-08-08','2014-08-08','A')
insert into FC_M_empleado values(3,'Andres','De la Vera',98111111,998819,'Sur','Inventario',
'1990-08-08','2014-08-08','A')

--**********************
select * from IN_R_TIPO_PRODUCTO
delete from IN_R_TIPO_PRODUCTO
--insert IN_T_TIPO_PRODUCTO
insert into IN_M_PRODUCTO values('Pelota','A')
insert into IN_M_PRODUCTO values('Zapatos','A')
insert into IN_M_PRODUCTO values('Shorts','A')
insert into IN_M_PRODUCTO values('Guantes','A')
insert into IN_M_PRODUCTO values('Gorras','A')
insert into IN_M_PRODUCTO values('Gafas','A')

--*************************
select * from IN_R_TIPO_MEDIDA
delete from IN_R_TIPO_MEDIDA
--insert IN_R_TIPO_MEDIDA
insert into IN_M_PRODUCTO values('S','A')
insert into IN_M_PRODUCTO values('L','A')
insert into IN_M_PRODUCTO values('X','A')
insert into IN_M_PRODUCTO values('XL','A')
insert into IN_M_PRODUCTO values('XXL','A')
--Zapatos
insert into IN_M_PRODUCTO values('','A')
insert into IN_M_PRODUCTO values('','A')
insert into IN_M_PRODUCTO values('','A')

--*************************
select * from IN_M_PRODUCTO
delete from IN_M_PRODUCTO
--insert IN_M_PRODUCTO
insert into IN_M_PRODUCTO values('Camisas','1','1','2','1',45,10,60,0.50,0.75,'A')
insert into IN_M_PRODUCTO values('Zapatos','1','1','2','1',45,10,60,0.90,1.00,'A')
insert into IN_M_PRODUCTO values('Rosa','2','1','2','1',45,10,60,0.50,0.65,'A')
insert into IN_M_PRODUCTO values('Clavel','2','1','2','1',45,10,60,1.50,1.75,'A')
insert into IN_M_PRODUCTO values('Ficus','4','1','2','1',45,10,60,1.50,1.75,'A')
insert into IN_M_PRODUCTO values('Lemon','4','1','2','1',45,10,60,0.50,0.75,'A')
insert into IN_M_PRODUCTO values('Ficus','3','1','2','1',45,10,60,0.50,0.75,'A')
insert into IN_M_PRODUCTO values('Rosa','5','1','2','1',45,10,60,0.70,0.75,'A')
insert into IN_M_PRODUCTO values('Girasol','2','1','2','1',45,10,60,0.50,0.85,'A')
insert into IN_M_PRODUCTO values('Clavel','1','1','2','1',45,10,60,0.80,1.00,'A')

--**************************
select * from SG_M_MODULO
delete from SG_M_MODULO
--insert MODULO

--insert into SG_M_MODULO values(1,1,'Facturacion','adm','10-10-10','A')
insert into SG_M_MODULO values(1,1,'Inventario','adm','10-10-10','A')
--insert into SG_M_MODULO values(3,1,'Compras','adm','10-10-10','A')
insert into SG_M_MODULO values(2,1,'Seguridad','adm','10-10-10','A')

--***************
select * from SG_M_USUARIO
delete from SG_M_USUARIO
--insert USUARIO ADM
insert into SG_M_USUARIO values(1,1,1,'adm','administrador1234','10-10-10','A')

--*******************
select * from SG_M_PERFIL
delete from SG_M_PERFIL
--insert Perfil
insert into SG_M_PERFIL values(1,'Bodeguero','10-10-10','adm','10-10-10')
--insert into SG_M_PERFIL values(2,'Caja','10-10-10','adm','10-10-10')
insert into SG_M_PERFIL values(2,'Administrador','10-10-10','adm','10-10-10')
--insert into SG_M_PERFIL values(4,'Contador','10-10-10','adm','10-10-10')

--************************
select * from SG_M_PERFILUSUARIO
delete from SG_M_PERFILUSUARIO
--insert SG_M_PERFILUSUARIO
insert into SG_M_PERFILUSUARIO values(1,2,1,'10-10-10','adm','10-10-10','A')

--************************
select * from SG_M_OPCIONMENU
delete from SG_M_OPCIONMENU
--insert OpcionMenu
/*
--Menu Facturacion
insert into SG_M_OPCIONMENU values(1,1,'Mantenimiento','Mantenimiento Cliente','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(2,1,'Mantenimiento','Mantenimiento Empleado','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(3,1,'Proceso','Proceso Facturacion','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(4,1,'Proceso','Proceso Devolucion','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(5,1,'Reporte','Reporte Producto Mas Vendido','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(6,1,'Reporte','Reporte Producto Menos Vendido','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(7,1,'Reporte','Reporte Mejor Ventas','adm','10-10-10','A')
*/
--Menu Inventario
insert into SG_M_OPCIONMENU values(1,1,'Mantenimiento','Mantenimiento Producto','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(2,1,'Mantenimiento','Mantenimiento Bodega','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(3,1,'Mantenimiento','Mantenimento Percha','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(4,1,'Mantenimiento','Mantenimiento Movimiento de Inventario','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(5,1,'Mantenimiento','Mantenumuento Tipo de Producto','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(6,1,'Mantenimiento','Mantenimiento Medida','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(7,1,'Proceso','Proceso Movimiento de Inventario','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(8,1,'Proceso','Proceso Kardex','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(9,1,'Proceso','Proceso Bodega a Bodega','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(10,1,'Reporte','Reporte de Producto','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(11,1,'Reporte','Reporte de Bodega','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(12,1,'Reporte','Reporte de Percha','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(13,1,'Reporte','Reporte Tipo Producto','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(14,1,'Reporte','Reporte Movimiento Bodega','adm','10-10-10','A')

/*
--Menu Compra
insert into SG_M_OPCIONMENU values(22,3,'Mantenimiento','Mantenimiento Proveedor','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(23,3,'Proceso','Proceso Solicitud de Pedido','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(24,3,'Proceso','Proceso Orden de Compra','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(25,3,'Proceso','Proceso entrega de Pedido','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(26,3,'Proceso','Proceso Devolucion','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(27,3,'Proceso','Proceso Cotizacion','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(28,3,'Reporte','Reporte Consulta Generales','adm','10-10-10','A')
*/

--Menu Seguridad
insert into SG_M_OPCIONMENU values(15,2,'Mantenimiento','Mantenimiento Usuario','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(16,2,'Mantenimiento','Mantenimiento Perfil Usuario','adm','10-10-10','A')
insert into SG_M_OPCIONMENU values(17,2,'Mantenimiento','Mantenimento Perfil Menu','adm','10-10-10','A')


--***************************************************************************************
select * from SG_M_OPCIONMENUPERFIL
delete from SG_M_OPCIONMENUPERFIL
--insert SG_M_OPCIONMENUPERFIL
insert into SG_M_OPCIONMENUPERFIL values(1,2,1,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(2,2,2,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(3,2,3,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(4,2,4,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(5,2,5,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(6,2,6,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(7,2,7,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(8,2,8,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(9,2,9,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(10,2,10,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(11,2,11,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(12,2,12,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(13,2,13,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(14,2,14,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(15,2,15,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(16,2,16,'10-10-10','10-10-15','adm','A')
insert into SG_M_OPCIONMENUPERFIL values(17,2,17,'10-10-10','10-10-15','adm','A')




--HAbilitar botones SG para ADM
insert into FC_M_empleado values(1,'Juan','Vera',98989898,99999,'Cementerio','Compras',
'1990-08-08','2014-08-08','A')
select * from SG_M_USUARIO
insert into SG_T_OPCIONMENUXBOTON values (1,29,1,1)
insert into SG_T_OPCIONMENUXBOTON values (2,29,2,1)
insert into SG_T_OPCIONMENUXBOTON values (3,29,3,1)
insert into SG_T_OPCIONMENUXBOTON values (4,29,4,1)
insert into SG_T_OPCIONMENUXBOTON values (5,29,5,0)
insert into SG_T_OPCIONMENUXBOTON values (6,30,1,1)
insert into SG_T_OPCIONMENUXBOTON values (7,30,2,1)
insert into SG_T_OPCIONMENUXBOTON values (8,30,3,0)
insert into SG_T_OPCIONMENUXBOTON values (9,30,4,1)
insert into SG_T_OPCIONMENUXBOTON values (10,30,5,0)
insert into SG_T_OPCIONMENUXBOTON values (11,31,1,1)
insert into SG_T_OPCIONMENUXBOTON values (12,31,2,1)
insert into SG_T_OPCIONMENUXBOTON values (13,31,3,0)
insert into SG_T_OPCIONMENUXBOTON values (14,31,4,1)
insert into SG_T_OPCIONMENUXBOTON values (15,31,5,0)

delete SG_M_BOTON
--Insertar datos a los botones
insert into SG_M_BOTON values(1,'Nuevo','A')
insert into SG_M_BOTON values(2,'Guardar','A')
insert into SG_M_BOTON values(3,'Consultar','A')
insert into SG_M_BOTON values(4,'Modificar','A')
insert into SG_M_BOTON values(5,'Eliminar','A')
insert into SG_M_BOTON values(6,'Anular','A')

--SP

--hbilitarperfil()
select * from SG_M_OPCIONMENU
select * from SG_M_OPCIONMENUPERFIL
select * from SG_M_PERFILUSUARIO
select * from SG_M_PERFIL
select * from SG_M_USUARIO

select Codigo_OpcionMenu from SG_M_OPCIONMENUPERFIL where ((select b.Codigo_Perfil from SG_M_USUARIO a, SG_M_PERFILUSUARIO b where a.Usuario='adm') = Codigo_Perfil)