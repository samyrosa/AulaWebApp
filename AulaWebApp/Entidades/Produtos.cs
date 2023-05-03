﻿using Microsoft.AspNetCore.Mvc;

namespace AulaWebApp.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}

