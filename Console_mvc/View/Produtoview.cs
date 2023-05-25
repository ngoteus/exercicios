using Console_mvc.Model;
using Console_mvc.Controller;

namespace Console_mvc.View
{
    public class Produtoview
    {
        public void Listar(List<Produto> produto)
        {
            Console.Clear();

            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco}");
            }
        }
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            
            return novoProduto;
        }
    }
}