using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_v2.Classes
{
    public class Proveedor
    {
        public int ID { get; private set; }
        public String razonSocial { get; set; }
        public String ruc { get; set; }
        public String telefono { get; set; }
        public String direccion { get; set; }

        public void Guardar()
        {
            if (0 == ID)
            {// es un nuevo objeto
                this.ID = new Random().Next(1000);
            }
            Utilitarios.LISTA_PROVEEDORES[this.ID] = this;
        }

    }
}
