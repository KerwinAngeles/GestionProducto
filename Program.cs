using System;

namespace SistemaGestionProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de productos que desea obtener");
            int cantidadProducto = int.Parse(Console.ReadLine());
            Producto[] productos = new Producto[cantidadProducto];
            int opc = 0;

            do
            {
                Console.WriteLine("SISTEMA DE GESTION DE PRODUCTOS");
                Console.WriteLine("---MENU DE OPCIONES---" +
                "\n 1: Agregar Productos " +
                "\n 2: Cantidad De Productos Creados " +
                "\n 3: Vender " +
                "\n 4: Mostrar Productos " +
                "\n 5: Salir");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:

                        Console.Clear();
                        for (int i = 0; i < cantidadProducto; i++)
                        {
                            Console.WriteLine($"Ingresa el {i + 1} producto");
                            string nombreProducto = Console.ReadLine();

                            Console.WriteLine($"Ingresa el precio del {i + 1} producto {nombreProducto} ");
                            int precio = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Del producto {nombreProducto} cuanto desea agregar??");
                            int cantidadProduct = int.Parse(Console.ReadLine());
                            productos[i] = new Producto(nombreProducto, precio, cantidadProduct);
                            productos[i].AgregarCantidad(cantidadProduct);
                        }

                        Console.WriteLine("Producto agregado exitosamente");
                        Console.ReadKey();

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine($"Cantidad de productos creados: {Producto.contadorProductos()}");
                        Console.ReadKey();
                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del producto que desea vender");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Cuantos producto desea vender?");
                        int productosVendidos = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cantidadProducto; i++)
                        {
                            productos[i].Vender(productosVendidos, nombre);
                        }
                        Console.WriteLine("Producto vendido exitosamente");
                        Console.ReadKey();
                        break;

                    case 4:

                        Console.Clear();
                        Console.WriteLine("PRODUCTOS DEL SISTEMA");
                        for (int i = 0; i < cantidadProducto; i++)
                        {
                            productos[i].ImprimirInformacion();
                           
                        }
                        Console.ReadKey();

                        break;

                    default:
                        break;

                }
            } while (opc != 5);

        }
    }
}
