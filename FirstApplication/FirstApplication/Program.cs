using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            //Asignación del mismo valor

            edadPersona1= edadPersona2= edadPersona3= edadPersona4=27;

            Console.WriteLine(edadPersona4);

            //Declarar variables con el mismo tipo de dato
            //int edadPersona1, edadPersona2, edadPersona3, edadPersona4;


            //Declaración implicita de variables

            var edadPersona = 27;

            edadPersona = 27.5; //Se debe respetar el tipo en toda la ejecución del programa

            Console.WriteLine(edadPersona);

        }

    }

}