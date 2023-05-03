using AulaWebApp.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApp_Manha;

namespace AulaWebApp.Controllers
{
    public class PermissaoController : Controller
    {
        private Contexto Contexto;

        public PermissaoController(Contexto db)
        {
            this.Contexto = db;
        }

        public IActionResult Lista()
        {

            return View(Contexto.permissao.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult SalvarDados(PermissaoEntidade dados)
        {
            Contexto.permissao.Add(dados);
            Contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
