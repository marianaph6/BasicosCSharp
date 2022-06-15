using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");

            // Console.ReadLine(); //Introducir valor por consola
            
            /*
             * Guardar valor digitado en una variable
             * Un string no se puede convertir implicitamente a int
             */
            //int num1 = Console.ReadLine();

            //Convertir string a int
            int num1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es {num1+num2}");




        }

    }

}