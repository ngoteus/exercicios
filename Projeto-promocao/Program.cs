string[] nome = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];
// promocao = true = Console.WriteLine($"O produto esta em promocao.");
// promocao = false = Console.WriteLine($"O produto nao esta em promocao.");
char opcao ='a';
static char menu()
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine(@$"O que deseja fazer:
    1- Para cadastrar produtos
    2- Listar produtos (Voce so podera listar, se ja tiver cadastrado algum produto.)
    0- para sair.
    4- para Mostrar o Menu novamente
    ");
    Console.ResetColor();
    return char.Parse(Console.ReadLine());

}
do
{

 opcao=menu();
    

    switch (opcao)
    {
        case '1':
            for (int i = 0; i < 10; i++)
            {
                //     Console.WriteLine(@$"Deseja cadastrar {i+1}ª Produto
                //     Se sim, Digite 'S'
                //     Senao, Digite  'N' ?");
                //     char cadastrar = char.Parse(Console.ReadLine());

                // if (cadastrar == 'S')
                // {


                Console.WriteLine($"Digite o nome do {i + 1}ª produto: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine($"Qual o preco do {i + 1}ª produto: ");
                preco[i] = float.Parse(Console.ReadLine());

                Console.WriteLine(@$"
O {i + 1}ª produto esta em promocao?
Digite 'S' para Sim
Digite 'N' para Nao");
                char respostaPromocao = char.Parse(Console.ReadLine());
                if (respostaPromocao == 'S')
                {
                    promocao[i] = true;

                }
                else if (respostaPromocao == 'N')
                {
                    promocao[i] = false;
                    // if(promocao[i]==true)
                    // {
                    //     Console.WriteLine($"O produto esta em promocao.");

                    // }
                    // else
                    // {
                    //     Console.WriteLine($"O produto nao esta em promocao.");

                    // }
                }

                else
                {

                    Console.WriteLine($"Voce digitou a letra errada!");

                }
            }
            break;
        case '2':
            for (int i = 0; i < 10; i++)
            {
                // Console.WriteLine($"Voce cadastrou {i+1} produtos!");

                if (promocao[i] == true)
                {
                    Console.WriteLine($" {i + 1}ª Produto: {nome[i]} custa R${preco[i]}, e Esta em promocao!");
                }
                else if (promocao[i] == false)
                {
                    Console.WriteLine($" {i + 1}ª Produto: {nome[i]} custa R${preco[i]}, e Nao esta em promocao!");
                }

                // Console.WriteLine($" {i+1}ª Produto: {nome[i]} custa {preco[i]}, e {promocao[i]}");
                // Console.WriteLine($" {i}ª Produto: {nome[i]} custa {preco[i]}, e {promocao[i]}");
            }
            break;

    }

} while (opcao != '0');

//  else if(cadastrar == 'N')
//  {
//     Console.WriteLine($"Ok! ");
//     break;
//     }
// for (int i = 1; i <= 10; i++)
// {

// }
//  }

// Console.WriteLine(@$"Deseja listar os produtos
//  Digite 'S' para Sim
//  Digite 'N' para Nao ?");
// char listar = char.Parse(Console.ReadLine());
// if (listar == 'S')
// {
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine($"Voce cadastrou {i + 1} produtos!");

//         if (promocao[i] == true)
//         {
//             Console.WriteLine($" {i + 1}ª Produto: {nome[i]} custa R${preco[i]}, e Esta em promocao!");
//         }
//         else if (promocao[i] == false)
//         {
//             Console.WriteLine($" {i + 1}ª Produto: {nome[i]} custa R${preco[i]}, e Nao esta em promocao!");
//         }

//         // Console.WriteLine($" {i+1}ª Produto: {nome[i]} custa {preco[i]}, e {promocao[i]}");
//         // Console.WriteLine($" {i}ª Produto: {nome[i]} custa {preco[i]}, e {promocao[i]}");
//     }
// }
// else if (listar == 'N')
// {
//     Console.WriteLine($"Ok! o programa sera finalizado.");

// }



