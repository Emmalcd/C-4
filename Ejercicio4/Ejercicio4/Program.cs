using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            ConsoleKeyInfo tecla;
            int ascii;
            Console.WriteLine("Ingresar un string y presionar enter");
            //Console.WriteLine();
            entrada = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Usted ha ingresado {entrada}");
            Console.WriteLine($"Ingrese una tecla y presione Enter: ");
            tecla=Console.ReadKey();
            Console.ReadKey();
            Console.WriteLine();

            ascii= (int)tecla.KeyChar;
            Console.WriteLine();
            Console.WriteLine($"La tecla {tecla.KeyChar} tiene como código ascii: {ascii}");
            Console.Read();

        }
    }
}
