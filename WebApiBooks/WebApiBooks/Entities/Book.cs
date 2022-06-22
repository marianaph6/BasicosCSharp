using System.ComponentModel.DataAnnotations;

namespace WebApiBooks.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }

 
        //Propiedad de navegación
        public int AutorId { get; set; }
      
        public Autor? Autor { get; set; }    
    }
}
