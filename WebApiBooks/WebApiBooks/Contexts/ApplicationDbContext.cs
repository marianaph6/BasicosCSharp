using Microsoft.EntityFrameworkCore;
using WebApiBooks.Entities;

namespace WebApiBooks.Context
{
    //Contexto de datos
    //Se configuran las tablas de la BD
    //Configuración de campos a nivel de tabla
    public class ApplicationDbContext : DbContext
    {
        //crear constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //La clase autor se va a corresponder con una tabla en la BD
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}

