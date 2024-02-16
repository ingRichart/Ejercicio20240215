using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstrumentoMusical.ClasesBase
{
    public abstract class Instrumento
    {
        public abstract string Tocar();

        public abstract bool Tocar(int numeroVeces);

        public abstract int Tocar(int numeroVeces, string canto);

        public abstract double Tocar(string canto, int numeroVeces);

    }
}