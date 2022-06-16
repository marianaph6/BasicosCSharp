using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PI = 3.1416;

            Console.WriteLine("Introduce el radio");

            double radio = double.Parse(Console.ReadLine());
            var area = calcularArea(radio, PI);


            Console.WriteLine($"El area del circulo es: {area}");

            calcularAreaMensaje(radio, PI);

        }


        static double calcularArea(double radio, double PI)
        {
            double area = Math.Pow(radio, 2) * PI;
            return area;
        }


        static void calcularAreaMensaje(double radio, double PI)
        {
            double area = Math.Pow(radio, 2) * PI;
            Console.WriteLine($"El area del circulo es: {area}");
        }

    }


}