using Basic_asp01.Models;
using Microsoft.EntityFrameworkCore;

namespace Basic_asp01.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
