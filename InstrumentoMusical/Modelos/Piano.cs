using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentoMusical.ClasesBase;

namespace InstrumentoMusical
{
    public class Piano : Instrumento
    {
        public override string Tocar()
        {
            throw new NotImplementedException();
        }

        public override bool Tocar(int numeroVeces)
        {
            throw new NotImplementedException();
        }

        public override int Tocar(int numeroVeces, string canto)
        {
            for (var i = 0; i < numeroVeces; i++)
            {
                Console.WriteLine(canto);
            }

            return numeroVeces;
        }

        public override double Tocar(string canto, int numeroVeces)
        {
            throw new NotImplementedException();
        }
    }
}