using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDos
{
    class Program
    {
        static void Main(string[] args)
        {
            float PrecioProducto;

            Console.WriteLine("BIENVENIDO A MEGAPLAZA");

            Console.Write("Ingrese el valor de su compra: ");

            PrecioProducto = float.Parse(Console.ReadLine());

            if (PrecioProducto > 300)
            {
                Console.WriteLine("Descuento es de: Q." + PrecioProducto * 0.2 + "\nTotal a pagar: Q." + (PrecioProducto - (PrecioProducto * 0.2)));
            }
            else
            {
                Console.WriteLine("Descuento no disponible. \nTotal a pagar: Q."+PrecioProducto);
            }

            Console.ReadKey();
        }
    }
}
