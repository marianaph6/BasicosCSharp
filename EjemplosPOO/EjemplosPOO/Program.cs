namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche =  new Coche(4500.25,1200.35);

            coche.setExtras(true,"HOLLLLA");
            Console.WriteLine(coche.getExtras());
            
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

        public void setExtras(bool climatizador, String tapiceria) 
        {

            this.climatizador = climatizador;
            this.tapiceria=tapiceria;

            // TODO:

        }

        public String getExtras() 
        {
            return $"Extras del coche; \n tapiceria: {tapiceria} \n climatizador: {climatizador} ";
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