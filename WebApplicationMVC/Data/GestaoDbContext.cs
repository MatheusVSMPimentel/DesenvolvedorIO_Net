using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Data
{
    public class GestaoDbContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }

        public GestaoDbContext(DbContextOptions<GestaoDbContext> options)
        : base(options)
        {
            
        }
    }
}