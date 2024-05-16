using Microsoft.EntityFrameworkCore;
using ReportProject.Models;

namespace ReportProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
    }
}
