using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            string DiaSemana;

            Console.Write("Lunes\nMartes\nMiercoles\nJueves\nViernes\nSabado\nDomingo\n\nIngresa un dia de la semana: ");

            DiaSemana = Console.ReadLine();

            
            switch (DiaSemana.ToLower())
            {
                case "lunes": case "martes": case "miercoles": case "jueves": case "viernes":
                    Console.WriteLine("Es un dia laboral.");
                    break;

                case "sabado": case "domingo":
                    Console.WriteLine("No es un dia laboral.");
                    break;

                default:
                    Console.WriteLine("Has ingresado un dia no especificado.");
                    break;
            }
            //Jorge Lopez :)
            Console.ReadKey();
        }
    }
}
