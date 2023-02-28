using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Index = Backend.Models.Index;

namespace Backend.DataAcces
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {
                
        }

        //DB Sets
        public DbSet<Users>? Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Index> Indexes { get; set; }



    }
}
