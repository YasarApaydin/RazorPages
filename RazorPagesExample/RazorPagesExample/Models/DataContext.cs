using Microsoft.EntityFrameworkCore;

namespace RazorPagesExample.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-98AUGDI\SQLEXPRESS;Database=RazorDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }


    }
}
