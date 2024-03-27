using Microsoft.EntityFrameworkCore;
using VenturaApiProject.DAL.Entities;

namespace VenturaApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=VenturaDbApi; User Id=sa; Password=Luofeng1907;TrustServerCertificate=true");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}