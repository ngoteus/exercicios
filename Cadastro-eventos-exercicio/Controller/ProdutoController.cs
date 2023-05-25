using Console_mvc.Model;
using Console_mvc.View;

namespace Cadastro_eventos_exercicio.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        Produtoview produtoview = new Produtoview();

        public void ListarProdutos()
        {
            List<Produto> produtos = produtos.Ler();

            produtoview.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = produtoview.Cadastrar();

            produto.Inserir(novoProduto);
        }
    }
}