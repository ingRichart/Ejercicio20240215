using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventarios.Modelos
{
    public class Stock
    {
        public Stock()
        {
            Inventarios = new List<Inventario>();
        }

        public List<Inventario> Inventarios { get; set; }
    }
}