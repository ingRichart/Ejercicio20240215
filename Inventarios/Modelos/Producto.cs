using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventarios.Base;

namespace Inventarios.Modelos
{
    public class Producto : Entity
    {
        private int id;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;

        public override int Id 
        { 
            get { return id; }
            set { id = value; } 
        }
        public override DateTime FechaCreacion 
        { 
            get { return fechaCreacion; } 
            set => fechaCreacion = value; 
        }
        public override DateTime FechaModificion
        {
            get
            {
                return fechaModificacion;
            }
            set => FechaModificion = value;
        }

        public string Nombre { get; set; }
        public string Categoria { get; set; }
    }
}