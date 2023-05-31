using Microsoft.EntityFrameworkCore;
using Projeto_Gamer2.Models;

namespace Projeto_Gamer2.Infra
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //User Id = "nome do seu usuario de login"
            //pwd = "Senha do seu usuario"
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = NOTE09-S14; initial catalog = gamermanha; User Id = sa; pwd = Senai@134; TrustServerCertificate = true");
            }
        }

        public DbSet<Jogador> Jogador {get; set;}
        public DbSet<Equipe> Equipe {get; set;}
    }
}