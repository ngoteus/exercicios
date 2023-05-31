using Cadastro_eventos_exercicio.Model;
using Cadastro_eventos_exercicio.Controller;
using Cadastro_eventos_exercicio.View;

Produto p = new Produto();

ProdutoController controller = new ProdutoController();
char resposta = '5';
do
{
    

Console.WriteLine(@$"
Se deseja cadastrar outro produto, Digite '1'
Se deseja listar os produtos, Digite '2'
Se deseja sair do programa, digite '0'");
resposta = char.Parse(Console.ReadLine());
// controller.CadastrarProduto();

switch (resposta)
{
    case '1':
        controller.CadastrarProduto();
        break;
    case '2':
        controller.ListarProdutos();
        break;
    case '0':
        break;

}
} while ( resposta !='0');


// controller.ListarProdutos();