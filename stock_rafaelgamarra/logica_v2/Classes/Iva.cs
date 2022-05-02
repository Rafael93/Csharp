using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_v2.Classes
{
    public class Iva
    {
        public int ID { get; private set; }
        public String descricion { get; set; }
        public String porcentaje { get; set; }

        public void Guardar()
        {
            if (0 == ID)
            {// es un nuevo objeto
                this.ID = new Random().Next(1000);
            }
            Utilitarios.LISTA_IVAS[this.ID] = this;
        }
    }
}
