using Cadastro_eventos_exercicio.Controller;
using Cadastro_eventos_exercicio.Model;

namespace Cadastro_eventos_exercicio.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descricao: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}");

            }

        }
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a descricao: ");
            novoProduto.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a Data: ");
            novoProduto.Data = DateTime.Parse(Console.ReadLine());

        List<Produto> produtos = new List<Produto>();
        Produto p = new Produto();

        produtos.Add(p);


//             Console.WriteLine(@$"
// Se deseja cadastrar outro produto, Digite '1'
// Se deseja listar os produtos, Digite '2'
// Se deseja sair do programa, digite '0'");
//             char resposta = char.Parse(Console.ReadLine());

            return novoProduto;

            //   Console.WriteLine(@$"
            //   Se deseja cadastrar outro produto, Digite '1'
            //   Se deseja listar os produtos, Digite '2'
            //   Se deseja sair do programa, digite '0'
            //   ");
            //   char resposta = char.Parse(Console.ReadLine());


        }
    }
}