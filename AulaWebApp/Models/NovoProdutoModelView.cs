using AulaWebApp.Entidades;

namespace AulaWebApp.Models
{
    public class NovoProdutoModelView : Produtos
    {
        public NovoProdutoModelView()
        {
            ListaCategorias = new List<Categoria>();
        }

        public List<Categoria> ListaCategorias { get; set; }
    }
}
