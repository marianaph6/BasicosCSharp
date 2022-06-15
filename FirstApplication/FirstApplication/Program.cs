using System;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura = 34.5;
            int temperaturaMadrid;

            //Conversión explicita → casting

            temperaturaMadrid = (int) temperatura;

            //Conversión implicita
            int habitantesCiudad = 100000;
            long habitantesCiudad2018 = habitantesCiudad;

            float pesoMaterial = 5.78F;

            double pesoMaterialPrec = pesoMaterial;



        }

    }

}