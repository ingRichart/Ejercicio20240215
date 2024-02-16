using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentoMusical.ClasesBase;

namespace InstrumentoMusical
{
    public class Trompeta : Instrumento
    {
        public override string Tocar()
        {
            return "Tocando Lisa Simpson";
        }

        public override bool Tocar(int numeroVeces)
        {
            throw new NotImplementedException();
        }

        public override int Tocar(int numeroVeces, string canto)
        {
            throw new NotImplementedException();
        }

        public override double Tocar(string canto, int numeroVeces)
        {
            int i = 1;
            do
            {
                Console.Write(canto);
                Console.WriteLine("+++++++");
               i++; 
            } while (i > numeroVeces);

            return numeroVeces / 3;
        }
    }
}