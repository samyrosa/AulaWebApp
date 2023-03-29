using Microsoft.AspNetCore.Mvc;

namespace AulaWebApp.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string nome, string telefone)
        {
            if (string.IsNullOrEmpty(nome))
            {
                TempData["Erro"] = "O campo nome nao pode estar em branco!";
            }
            if (string.IsNullOrEmpty(telefone))
            {
                TempData["Erro"] = "O campo telefone nao pode estar em branco!";
            }
            return View();
        }

        public IActionResult Editar(int Id)
        {
            return View();
        }

        public IActionResult Excluir(int Id)
        {
            return View();
        }
        public IActionResult Compras(int Id)
        {
            return View();
        }
    }
}
