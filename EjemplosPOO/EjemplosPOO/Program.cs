using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo;
            circulo = new Circulo(); //Iniciación de variable objeto de tipo circulo
            Console.WriteLine(circulo.calcularArea(47));
        }
    }

    class Circulo
    {
        double pi = 3.1416;

        public double calcularArea(int radio)
        {
            return (radio * pi * pi);

        }

    }

}