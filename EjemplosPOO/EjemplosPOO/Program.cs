using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo;
            circulo = new Circulo(); //Iniciación de variable objeto de tipo circulo
            Console.WriteLine(circulo.CalcularArea(47));

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiarValorEuro(1.45);
            Console.WriteLine(obj.convierte(50));
        }
    }

    class Circulo
    {
        private const double pi = 3.1416; //propiedad de la clase

        public double CalcularArea(int radio) // metodo de la clase
        {
            return (radio * pi * pi);

        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double convierte(double cantidad) 
        {
            return euro * cantidad;
        
        }

        public void cambiarValorEuro(double nuevoValor) 
        {
            if(nuevoValor < 0) euro = 1.253;
            else euro = nuevoValor;
        }
    }

}