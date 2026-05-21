using pryMaquinaExpendedora.Clases;

namespace pryMaquinaExpendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto sabritasAdobadas = new Producto("Sabritas adobadas", 20, 15);
            Producto galletasChokis = new Producto("Chokis", 15, 20);
            Producto galletasArcoiris = new Producto("Arcoiris", 16, 25);
            Producto sabritasOrigial = new Producto("Sabritas original", 20, 25);

            string respuesta;

            do
            {
                Console.WriteLine("------------ Catalogo de productos ------------");
                Console.WriteLine($"1. {sabritasAdobadas._nombreProducto} precio: {sabritasAdobadas._costo} existencia: {sabritasAdobadas._existencia}");
                Console.WriteLine($"2. {galletasChokis._nombreProducto} precio: {galletasChokis._costo} existencia: {galletasChokis._existencia}");
                Console.WriteLine($"3. {galletasArcoiris._nombreProducto} precio: {galletasArcoiris._costo} existencia: {galletasArcoiris._existencia}");
                Console.WriteLine($"4. {sabritasOrigial._nombreProducto} precio: {sabritasOrigial._costo} existencia: {sabritasOrigial._existencia}");


                Console.Write("\nSelecciona el producto (1-4):");
                int opc= int.Parse(Console.ReadLine());
                Console.Write("ingrsa la cantidad a llevar: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine(sabritasAdobadas.compra(cantidad));
                        break;
                    case 2:
                        Console.WriteLine(galletasChokis.compra(cantidad));
                        break;
                    case 3:
                        Console.WriteLine(galletasArcoiris.compra(cantidad));
                        break;
                    case 4:
                        Console.WriteLine(sabritasOrigial.compra(cantidad));
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.WriteLine("\n¿Quiere agregar otro producto?(si/no):");
                respuesta = Console.ReadLine().ToUpper();
            } while (respuesta == "SI");

        }
    }
}
