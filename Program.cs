using pryMaquinaExpendedora.Clases;

namespace pryMaquinaExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion de 4 distintos productos
            Producto sabritasAdobadas = new Producto("Sabritas adobadas", 20, 15);
            Producto galletasChokis = new Producto("Chokis", 15, 20);
            Producto galletasArcoiris = new Producto("Arcoiris", 16, 25);
            Producto sabritasOrigial = new Producto("Sabritas original", 20, 25);

            string respuesta;
            //ciclo de compra automatizada
            do
            {
                Console.WriteLine("------------ Catalogo de productos ------------");
                Console.WriteLine($"1. {sabritasAdobadas.mostrarProducto()}");
                Console.WriteLine($"2. {galletasChokis.mostrarProducto()}");
                Console.WriteLine($"3. {galletasArcoiris.mostrarProducto()}");
                Console.WriteLine($"4. {sabritasOrigial.mostrarProducto()}");

                Console.Write("\nSelecciona el producto (1-4): ");
                int opc= int.Parse(Console.ReadLine());
                Console.Write("ingresa la cantidad a llevar: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine(sabritasAdobadas.compra(cantidad));
                        Console.WriteLine(sabritasAdobadas.mostrarProducto());
                        break;
                    case 2:
                        Console.WriteLine(galletasChokis.compra(cantidad));
                        Console.WriteLine(galletasChokis.mostrarProducto());
                        break;
                    case 3:
                        Console.WriteLine(galletasArcoiris.compra(cantidad));
                        Console.WriteLine(galletasArcoiris.mostrarProducto());
                        break;
                    case 4:
                        Console.WriteLine(sabritasOrigial.compra(cantidad));
                        Console.WriteLine(sabritasOrigial.mostrarProducto());
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.Write("\n¿Quiere agregar otro producto?(si/no): ");
                respuesta = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");
            } while (respuesta == "SI");

        }
    }
}
