using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_U6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Productos.txt", true);
            
            int num, opcion;
            char resp;
            String str;
        do 
        {
            Console.WriteLine("**********Sistema De Inventarios Amazon**********");
            Console.WriteLine("1.- Registrar producto.");
            Console.WriteLine("2.- Lectura de un Archivo.");
            Console.WriteLine("3.- Salida del Programa");
            Console.Write("\nQue opción deseas: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                        Console.Clear();
                        Console.WriteLine("**********Registro de productos**********");
                        Console.WriteLine("¿Cual es el nombre del producto?");
                        string newNombre = Console.ReadLine();
                        Console.WriteLine("¿Cual es la descripción del producto?");
                        string newDescripcion = Console.ReadLine();
                        Console.WriteLine("¿Cual es su precio?");
                        float newPrecio = float.Parse(Console.ReadLine());
                        Console.WriteLine("¿Cual es la cantidad en Stock?");
                        int newStock = int.Parse(Console.ReadLine());

                        Productos productos = new Productos(newNombre, newDescripcion, newPrecio, newStock);
                        Console.Clear();
                        sw.WriteLine("Nombre: " + productos.nombre + "  |  Descripción: " + productos.descripcion + "  |  Precio: " + productos.precio + "  |  Cantidad en Stock: " + productos.cantidad); //Escribe en el archivo
                        Console.WriteLine("Registro completado con exito!");
                        break;
                   case 2:
                        Console.WriteLine(".....");

                        break;
                case 3:
                    Console.Write("Presione Enter para salir");
                    Console.ReadKey();
                    break;
                default:
                        Console.Clear();
                    Console.Write("Opción desconocida, presione Enter para volver");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 3);

            sw.Close(); //Cierra el archivo
        }
    }
}
