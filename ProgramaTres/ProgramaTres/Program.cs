using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramaTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int HorasObrero;
            int TotalPago;


            Console.Write("Cuantas horas ha trabajado el obrero? ->");

            HorasObrero = Convert.ToInt16(Console.ReadLine());

            if (HorasObrero <= 40)
            {
                TotalPago = HorasObrero * 16;
                Console.WriteLine("Total a pagar es de: Q."+TotalPago);
            }
            else if (HorasObrero > 40)
            {
                HorasObrero = HorasObrero - 40;
                TotalPago = (HorasObrero* 20) + 640;
                Console.WriteLine("Total a pagar es de: Q." + TotalPago);
            }
           

            Console.ReadKey();
        }
    }
}
