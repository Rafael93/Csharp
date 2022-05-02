using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_v2.Classes
{
    public class Cliente
    {
        public int ID { get; private set; }
        public string Sexo { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public String FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime Fechaingreso { get; set; }
        public String Direccion { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }

        public void Guardar()
        {
            if (0 == ID)
            {// es un nuevo objeto
                this.ID = new Random().Next(1000);
            }
            Utilitarios.LISTA_CLIENTES[this.ID] = this;
        }
    }
}
