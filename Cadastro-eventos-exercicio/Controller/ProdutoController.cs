using Cadastro_eventos_exercicio.Model;
using Cadastro_eventos_exercicio.View;

namespace Cadastro_eventos_exercicio.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoview = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoview.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = produtoview.Cadastrar();

            produto.Inserir(novoProduto);
        }
    }
}