using Microsoft.AspNetCore.Mvc;
using AulaWebApp.Entidades;

namespace AulaWebApp.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }


        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}

 