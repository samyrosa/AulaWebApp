using AulaWebApp.Entidades;
using AulaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp_Manha;

namespace AulaWebApp.Controllers
{
    public class CategoriasController : Controller
    {

        private Contexto db;

        public CategoriasController(Contexto _db)
        {
            this.db = _db;
        }

        public IActionResult Lista()
        {
            
            return View( db.Categorias.ToList() );
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir(int Id)
        {

            return RedirectToAction("Lista");
        }

        [HttpPost]
        public IActionResult SalvarDados(CategoriaViewModal dados)
        {
            Categoria entidade = new Categoria();
            entidade.Nome = dados.Nome;
            entidade.Id =   dados.Id;
            entidade.Ativo = dados.Ativo == "on" ? true : false;
            db.Categorias.Add(entidade);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
