
using Exercicio1;
using Microsoft.EntityFrameworkCore;


public class DbContextGremio
{
    // classe que representa o banco de dados
    public class AppDbContextGremio : DbContext
    {
        // propiedade que representa a tabela usuarios
        public DbSet<Usuario> Usuarios { get; set; }
        // métodos que configura informando para o EF que o banco  será SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BancoDoGremio.db");
        }
    }
}

