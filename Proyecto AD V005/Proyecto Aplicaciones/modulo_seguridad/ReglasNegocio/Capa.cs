using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_Seguridad
{
    public class Capa
    {
        Coneccio conec = new Coneccio();
        public Boolean conectar()
        {
            return this.conec.Conectando() != false ? true : false;
        }

    }
}
