using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentoMusical.ClasesBase;

namespace InstrumentoMusical.Modelos
{
    public class Guitarra : Instrumento
    {
        public override string Tocar()
        {
            return "Esta es la base";
        }

        public override bool Tocar(int numeroVeces)
        {
            if (numeroVeces > 5)
            {
                return true;
            }

            return false;
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
            int i = 1;
            while(i <= numeroVeces)
            {
                Console.WriteLine("+++++++++");
                Console.Write(canto);
                Console.WriteLine("+++++++++");

                i++;
            }

            return numeroVeces / 7;
        }
    }
}