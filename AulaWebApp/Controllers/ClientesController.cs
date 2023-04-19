using AulaWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaWebApp.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClienteViewModel> lista = new List<ClienteViewModel>();
        public IActionResult Lista()
        {
           
            //for (int i = 0; i < 16; i++)
            //{
            //    ClienteViewModel novo = new ClienteViewModel();
            //    novo.Id = i;
            //    novo.Nome = "Cliete Nome Sobrenome Outro Nome " + i;
            //    novo.Telefone = "9" + i + i + i + i +i;
            //    lista.Add(novo);
            //}

            return View(lista);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(ClienteViewModel model)
        {
            if (model.Id > 0)
            {
                int ix = lista.FindIndex(a => a.Id == model.Id);
                lista[ix] = model;
            }
            else
            {
                Random random = new Random();
                model.Id = random.Next();
                lista.Add(model);
            }


            return RedirectToAction("Lista");
        }

        //[HttpPost]
        //public IActionResult Cadastro(string nome, string telefone)
        //{
        //    if (string.IsNullOrEmpty(nome))
        //    {
        //        TempData["Erro"] = "O campo nome nao pode estar em branco!";
        //    }
        //    if (string.IsNullOrEmpty(telefone))
        //    {
        //        TempData["Erro"] = "O campo telefone nao pode estar em branco!";
        //    }
        //    return View();
        //}

        public IActionResult Editar(int Id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == Id);
            if (cliente != null)
            {
                return View(cliente);
            }
            return RedirectToAction("Lista");

        }

        public IActionResult Excluir(int Id)
        {   
            ClienteViewModel cliente = lista.Find(a  => a.Id == Id);
            if (cliente != null)
            {
                lista.Remove(cliente);
            }
            return RedirectToAction("Lista");
        }
        public IActionResult Compras(int Id)
        {
            return View();
        }
    }
}
