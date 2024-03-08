using Microsoft.EntityFrameworkCore;
using MyApplication.Models;
namespace MyApplication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Przychod> Przychody { get; set; }
        public DbSet<Koszt> Koszty { get; set; }
    }
}
