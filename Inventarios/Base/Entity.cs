using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventarios.Base
{
    public abstract class Entity
    {
        public abstract int Id { get; set; }
        public abstract DateTime FechaCreacion { get; set; }
        public abstract DateTime FechaModificion { get; set; }

    }
}