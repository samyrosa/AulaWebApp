using AulaWebApp.Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApp_Manha
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        { }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<PermissaoEntidade> permissao { get; set; }
    }
}