using Microsoft.EntityFrameworkCore;
using MyApplication.Models;
namespace MyApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Przychod> Przychody { get; set; }
        public DbSet<Koszt> Koszty { get; set; }
        public DbSet<Kontrakt> Kontrakty { get; set; }
        public DbSet<ZestawienieMiesieczneFirmy> ZestawienieMiesieczneFirmy { get; set; }
        public DbSet<ZestawienieGodzinPracy> ZestawienieGodzinPracy { get; set; }
        public DbSet<Podatek> Podatek { get; set; }
        public DbSet<GodzinyPracy> GodzinyPracy { get; set; }

    }
}
