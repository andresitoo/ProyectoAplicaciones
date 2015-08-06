using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturacion
{
    class Capa2
    {
        Coneccion conec = new Coneccion();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

        public Boolean RegistraFactura(int coem, int cof, int coe, int coc,DateTime fec, 
            String sub, String iva, String tot, char est)
        {
            return this.conec.RegistrarFactura(coem, cof, coe, coc, fec, sub,
            iva, tot, est);
        }

        public Boolean RegistraClienteNuevo(int cod, int ruc, int id, String razon,
            String nombre, String apellido, String direccion, int telefono,char x,char y)
        {
            return this.conec.IngresaUsuario(cod, ruc, id, razon, nombre, apellido, direccion, telefono,x,y);
        }
        public Boolean ModificarClienteNuevo(int cod, int ruc, int id, String razon,
            String nombre, String apellido, String direccion, int telefono)
        {
            return this.conec.ModificaUsuario(cod, ruc, id, razon, nombre, apellido, direccion, telefono);
        }
        public Boolean EliminarClienteNuevo(int cod)
        {
            return this.conec.EliminarUsuario(cod);
        }
        public Boolean ConsultarClienteNuevo(int cod)
        {
            return this.conec.ConsultarUsuario(cod);
        }

        public Boolean eliminaFactura(int cod)
        {
            return this.conec.eliminarFactura(cod);
        }


        public void IngrAnulacion(int co, DateTime fecha, String mo)
        {
            this.conec.Anula(co,fecha,mo);
        }
    }
}
