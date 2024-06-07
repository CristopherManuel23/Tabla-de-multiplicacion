using System;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Esto es un programa para saber la tabla de multilicasion\n ");

            Console.WriteLine("\n Ingrese un Numero de la tabla a Saber\n");
            int Nume1 = int.Parse(Console.ReadLine());

            int Num = 0;
            while (Num <= 12)
            {
                Console.WriteLine($" {Nume1} x {Num} = { Nume1 * Num}");
                Num++; 
            }

        }
    }
}
