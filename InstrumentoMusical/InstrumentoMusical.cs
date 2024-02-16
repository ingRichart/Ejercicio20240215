/*

Crea una clase abstracta llamada InstrumentoMusical con un método abstracto para tocar(). Luego, implementra clases concretas como Piano, Guitarra y Trompeta que hereden de la clase InstrumentoMusical y proporcionen diferentes implementaciones para el método tocar().

*/

using InstrumentoMusical;
using InstrumentoMusical.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Guitarra guitar = new Guitarra();
        Piano piano = new Piano();
        Trompeta trompeta = new Trompeta();

        Console.WriteLine(guitar.Tocar());
        Console.WriteLine(guitar.Tocar(10));
        guitar.Tocar(5,"Boom boom");
        guitar.Tocar("oh lalala", 3);

    }
}

