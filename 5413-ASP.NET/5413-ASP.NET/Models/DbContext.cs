using Microsoft.EntityFrameworkCore;



namespace _5413_ASP.NET.Models
{
    // Classe que representa o contexto do banco de dados
    public class AppDbContext:DbContext
    {


        // Construtor que recebe as opes de configurao do banco de dados
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {   }




        // Propriedades que representam as tabelas do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }



        // passar as informcoes de conexao para o banco de dados
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
