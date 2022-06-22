using System.ComponentModel.DataAnnotations;

namespace WebApiBooks.Entities
{
    //En entities se guardadn las entidades que van a corresponder con la BD  
    public class Autor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Book>? Books { get; set; }  
    }
}
