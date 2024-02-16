using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventarios.Modelos
{
    public class Inventario
    {
        public Inventario()
        {
            Producto = new Producto();
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}