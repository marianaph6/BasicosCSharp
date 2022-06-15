using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(7 * 5);
            Console.WriteLine(7 * 5 * 3);
            Console.WriteLine(5/2); //Se ofrece el resultado del mismo tipo de dato de los operandos
            Console.WriteLine(5.0 / 2.0); //Se toman como double
            Console.WriteLine(5 / 2.0); //Entero/Decimal → Decimal
            Console.WriteLine(9%4);

            int edad = 19;

            Console.WriteLine("Tienes una edad de: "+ edad + " años"); //Concatenación con +
            Console.WriteLine($"Tienes una edad de: {edad} años"); //Interpolación de String

            //Uso como sufijo

            edad++; //Incremento
            edad--; //Decremento
            
            //Uso como prefijo
            Console.WriteLine($"Tienes una edad de: {++edad} años"); 
            Console.WriteLine($"Tienes una edad de: {--edad} años"); 

        }

    }

}