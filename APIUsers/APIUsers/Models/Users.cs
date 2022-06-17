using System.ComponentModel.DataAnnotations;

namespace APIUsers.Models
{
    public class Users
    {
        //prop+ double TAB → public int MyProperty { get; set; }

        //Crear modelo de Users, asignar propiedades y data annotations (cuando el modelo pase a ser una tabla)

        [Key]
        public int Id{ get; set; }

        [Required]
        public string Name{ get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
