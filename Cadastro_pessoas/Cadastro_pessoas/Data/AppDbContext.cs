using Cadastro_pessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_pessoas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Pessoas> Pessoas { get; set; } = null;
    }
    
}
