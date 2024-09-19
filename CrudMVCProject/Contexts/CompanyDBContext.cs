using Microsoft.EntityFrameworkCore;
using CrudMVCProject.Models;

namespace CrudMVCProject.CompanyContext
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options)
        : base(options)
        {
        }
        public DbSet<CrudMVCProject.Models.Employee> Employee { get; set; } = default!;

    }
}
