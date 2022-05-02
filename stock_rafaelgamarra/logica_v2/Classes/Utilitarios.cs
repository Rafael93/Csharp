using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_v2.Classes
{
    public class Utilitarios
    {
        public static Dictionary<int, Cliente> LISTA_CLIENTES = new Dictionary<int, Cliente>();
        public static Dictionary<int, Iva> LISTA_IVAS = new Dictionary<int, Iva>();
        public static Dictionary<int, Producto> LISTA_PRODUCTOS = new Dictionary<int, Producto>();
        public static Dictionary<int, Proveedor> LISTA_PROVEEDORES = new Dictionary<int, Proveedor>();
    }
}
