using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR = 5;

            const int VALOR2 = 6;

            // cw+TAB → Console.WriteLine();
            Console.WriteLine("El valor de la constante es: ", VALOR); //Imprimir con parametros

            Console.WriteLine("El valor de la constante es: {0} ", VALOR, VALOR2); //Imprimir con el parametro 1 

            Console.WriteLine("El valor de la constante es: {1} ", VALOR, VALOR2); //Imprimir con el parametro 1 

            /*
             * Ejemplo de calculo de area
             */

            const double PI = 3.1416;

            Console.WriteLine("Introduce el radio");

            double radio= double.Parse(Console.ReadLine());
            //double area = radio * radio * PI;
            double area = Math.Pow(radio,2)* PI;

            Console.WriteLine($"El area del circulo es: {area}");



        }

    }

}