using APIUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace APIUsers.Data
{
    public class ApplicationDbContext: DbContext
    {
        //ctor + double Tab → Constructor class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
            
        }

        public DbSet<User> Users { get; set; }
    }
}
