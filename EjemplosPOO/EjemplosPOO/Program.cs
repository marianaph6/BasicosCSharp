using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche =  new Coche();
            
        }

    }

    class Coche 
    {
        //Dar estado inicial a los objetos de tipo coche
        public Coche() 
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        //Dar estado inicial a los objetos de tipo coche con parametros
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }




        public String getInfoCoche() 
        {
            return $"Información del coche: Ruedas: {ruedas} Largo: {largo} Ancho: {ancho}";
        }
        private int ruedas;
        private double largo, ancho;
        private bool climatizador;
        private String tapiceria;
    }



}