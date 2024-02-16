/*

Crea un sistema de gestión de inventarios para una tienda que permita agregar productos al inventario, realizar ventas, llevar un registro de las existencias y generar informes de ventas. 

Utiliza clases como Producto, Inventario, Venta, Reportes, y aplique los conceptos de encapsulamiento, herencia y polimorfismo.

*/

using Inventarios.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {

        Stock stock = new Stock();
        string respuesta;
        int id = 0;
        //Crear mis productos (CRUD =Create, Read, Updated, Deleted)
        // ABC (Altas, Bajas y Cambios)
        do
        {
            Console.Clear();
            
            id++;
            Producto producto = new Producto();
            producto.Id = id;
            Console.WriteLine("Dame el nombre del Producto?");
            producto.Nombre = Console.ReadLine();
            producto.FechaCreacion = DateTime.Now;
            
            Inventario inventario = new Inventario();
            inventario.Producto = producto;

            Console.WriteLine("Dame la cantidad del Producto?");
            inventario.Cantidad = Convert.ToInt32(Console.ReadLine());
            stock.Inventarios.Add(inventario);
            Console.WriteLine("Deseas agregar mas productos Y/N");
            respuesta = Console.ReadLine();

        } while (respuesta == "Y");


    }
}