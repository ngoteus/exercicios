using Console_mvc.Model;
using Console_mvc.View;


namespace Console_mvc.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        Produtoview produtoView = new Produtoview();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);

        }
    }
}