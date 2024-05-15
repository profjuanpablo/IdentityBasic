using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AulaIdentity.Models;

namespace AulaIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AulaIdentity.Models.Produto> Produto { get; set; } = default!;
        public DbSet<AulaIdentity.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
