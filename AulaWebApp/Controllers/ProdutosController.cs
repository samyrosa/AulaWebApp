﻿using AulaWebApp.Entidades;
using Microsoft.AspNetCore.Mvc;
using AulaWebApp.Models;
using AulaWebApp;
using WebApp_Manha;
using Microsoft.EntityFrameworkCore;

namespace AulaWebApp.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto db;

        public ProdutosController(Contexto contexto)
        {
            db = contexto;
        }


        public IActionResult Lista()
        {
            List<Produtos> model = new List<Produtos>();
            model = db.Produto.Include(a => a.Categoria).ToList();
            return View(model);
        }

        public IActionResult Cadastro()
        {
            NovoProdutoModelView model = new NovoProdutoModelView();
           
            model.ListaCategorias = db.Categorias.ToList();

            return View(model);
        }
        [HttpPost]
        public IActionResult SalvarDados(Produtos dados)
        {
            db.Produto.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
