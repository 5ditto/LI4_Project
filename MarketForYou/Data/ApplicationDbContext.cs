using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MarketForYou.Models;

namespace MarketForYou.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MarketForYou.Models.Feira> Feira { get; set; }
        public DbSet<MarketForYou.Models.Comentario> Comentario { get; set; }
        public DbSet<MarketForYou.Models.Feirante> Feirante { get; set; }
        public DbSet<MarketForYou.Models.Produtos> Produtos { get; set; }
        public DbSet<MarketForYou.Models.ReportErros> ReportErros { get; set; }
    }
}