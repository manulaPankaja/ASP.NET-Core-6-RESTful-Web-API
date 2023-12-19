using StudentApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentApplication
{
    public class ApplicationDbContext : DbContext
    {
        //constructors
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :  base (options) { }

        //add models to db context
        public virtual DbSet<StudentModel> Students { get; set; }
    }
}
