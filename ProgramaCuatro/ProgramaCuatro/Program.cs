using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;

            Console.Write("Ingrese el anio que desea saber: ");

            anio = Convert.ToInt32(Console.ReadLine());

            if ((anio % 4 == 0) && (anio % 100 == 0) && (anio % 400 == 0))
            {
                Console.WriteLine("Es un anio bisiesto.");
                Console.WriteLine("Meses con 30 días: Abril, Junio, Septiembre y Noviembre.");
                Console.WriteLine("Meses con 31 días: Enero, Marzo, Mayo, Julio, Agosto, Octubre y Diciembre.");
                Console.WriteLine("Meses con 29 días: Febrero (Porque es bisiesto.).");
            }
            else
            {
                Console.WriteLine("No es un anio bisiesto.");
                Console.WriteLine("Meses con 30 días: Abril, Junio, Septiembre y Noviembre.");
                Console.WriteLine("Meses con 31 días: Enero, Marzo, Mayo, Julio, Agosto, Octubre y Diciembre.");
                Console.WriteLine("Meses con 28 días: Febrero.");
            }
            Console.ReadKey();
        }
    }
}
