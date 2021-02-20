using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaSeis
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int contador = 0; 
            int dato;


            Console.Write("Ingrese un dato: ");

            dato = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < (dato + 1); i++)
            {
                if (dato % i == 0)
                {
                    contador++;
                }
            }

            if (contador != 2)
            {
                Console.WriteLine("No es primo");
            }
            else
            {
                Console.WriteLine("Si es primo");
            }
            Console.ReadKey();
        }
    }
}
