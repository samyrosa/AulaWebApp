using AulaWebApp.Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApp_Manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        { }

        public DbSet<Produtos> Produtos { get; set; }

        public DbSet<Categorias> Categorias { get; set; }



    }
}