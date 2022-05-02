using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_v2.Classes
{
    public class Producto
    {
        public int ID { get; private set; }
        public String nombre { get; set; }
        public String tipoProducto { get; set; }
        public int cantidadTotal { get; set; }
        public String unidadMedida { get; set; }
        public int cantidadMinima { get; set; }
        public int precioCompra { get; set; }
        public int margenGanancia { get; set; }
        public int iva { get; set; }
        public int precioVenta { get; set; }

        public void Guardar()
        {
            if (0 == ID)
            {// es un nuevo objeto
                this.ID = new Random().Next(1000);
            }
            Utilitarios.LISTA_PRODUCTOS[this.ID] = this;
        }
    }
    
}
