using Microsoft.EntityFrameworkCore;

namespace ApiSqlCurso.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Contacts> ContactSet {get; set;}
    }
}