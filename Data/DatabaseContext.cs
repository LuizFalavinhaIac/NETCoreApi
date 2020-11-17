using ApiLoja.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLoja.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;DataBase=local-db;Uid=root");
        }
    }
}
