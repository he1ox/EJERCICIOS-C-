using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramRepeat = true;

            do
            {
                try
                {
                    ProgramRepeat = false;
                    
                    char letra;
                    Console.Write("Ingresa un caracter: ");

                    letra = Convert.ToChar(Console.ReadLine());

                    if (Char.IsUpper(letra))
                    {
                        Console.WriteLine("El caracter " + letra + " es mayuscula.");
                    }
                    else
                    {
                        Console.WriteLine("El caracter " + letra + " es minuscula.");
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Debes ingresar un UNICO caracter. \n Presiona cualquier tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    ProgramRepeat = true;
                }
            } while (ProgramRepeat == true);

            Console.ReadKey();
        }
    }
}
