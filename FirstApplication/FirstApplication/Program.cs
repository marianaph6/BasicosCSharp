using System;

namespace FirstApplication
{
    class Program
    {

        int numero1 = 5; //variables a nivel de clase
        int numer2 = 7;
        static void Main(string[] args)
        {

            const double PI = 3.1416;

            Console.WriteLine("Introduce el radio");

            double radio = double.Parse(Console.ReadLine());
            var area = calcularArea(radio, PI);


            Console.WriteLine($"El area del circulo es: {area}");

            calcularAreaMensaje(radio, PI);

        }
        //no se puede hacer sobre carga de metodos (mismo nombre y misma cantidad de parametros y mismo tipo de datos)
        static int Suma (int operador1, int operador2) => operador1 + operador2;    


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

        void primerMetodo()
        {
            int numero = 5; //variable de ambito local

            Console.WriteLine(numero1 + numer2);

        }



        void segundoNumero()
        {
            Console.WriteLine(numero1 + numer2);

        }
    }
}


