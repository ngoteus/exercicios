string[] nome = new string[5];
string[] origem = new string[5];
string[] Destino = new string[5];
string[] data = new string[5];

int senha = 123456;

// return true ; 
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Bem vindo a companhia aerea de maua!");


    Console.WriteLine(@$"
    1-Para cadastrar
    0-Para sair.");
    char cadastrar = char.Parse(Console.ReadLine());

    while (cadastrar != '0')
    {


        if (cadastrar == '1')
        {
            Console.WriteLine($"Insira sua senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha != 123456)
            {
                Console.WriteLine($"Senha incorreta!");

                // return false ;

            }
            else
            {
                Console.WriteLine($"Senha correta!");
                Console.WriteLine($"Insira seu nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Origem: ");
                origem[i] = Console.ReadLine();

                Console.WriteLine($"Destino: ");
                Destino[i] = Console.ReadLine();

                Console.WriteLine($"Data do voo: ");
                data[i] = Console.ReadLine();

                Console.WriteLine($"Sua passagem foi cadastrada, se desejar listar ela, digite '2', senao digite '0' para sair");
                cadastrar = char.Parse(Console.ReadLine());
                if (cadastrar == '2')
                {
                    Console.WriteLine(@$"
    Passagem #{i}
    nome: {nome[i]} 
    origem: {origem[i]} 
    Destino: {Destino[i]} 
    Data do voo: {data[i]}.
    Digite 0 para cadastrar outro passageiro ");
                    cadastrar = char.Parse(Console.ReadLine());
                }
                else if (cadastrar == '0')
                {
                    Console.WriteLine($"Voce saiu com sucesso!");

                }
                // char cadastrar = char.Parse(Console.ReadLine());

                else
                {
                    Console.WriteLine($"Codigos digitados errados.");
                }
            }
        }
    }
}


// }
// else
// {


// }

// }

// Console.WriteLine($"Insira sua senha: ");
// senha = int.Parse(Console.ReadLine());


// static bool senhaVerdadeira(int senha)
// {

// }


// if (senha != 123456)
// {
//     Console.WriteLine($"Senha incorreta!");

//     // return false ;

// }
// else
// {
//     Console.WriteLine($"Senha correta!");
//     // return true ; 
//     for (int i = 1; i <= 5; i++)
//     {
//         Console.WriteLine($"Insira seu nome: ");
//         nome[i] = Console.ReadLine();

//         Console.WriteLine($"Origem: ");
//         origem[i] = Console.ReadLine();

//         Console.WriteLine($"Destino: ");
//         Destino[i] = Console.ReadLine();

//         Console.WriteLine($"Data do voo: ");
//         data[i] = Console.ReadLine();

//         Console.WriteLine(@$"1-Para cadastrar.
// 2- Para listar passagem.
// 0-Para sair.");
//         char cadastrar = char.Parse(Console.ReadLine());
//         }


// }
// while (cadastrar !=0)
// {


//         switch (cadastrar)
//         {
//             case '1':
//                 Console.WriteLine($"Sua passagem foi cadastrada. Deseja listar a passagem? Digite 2 se sim, ou 0 pra sair!");
//                 cadastrar = char.Parse(Console.ReadLine());
//                 break;

//             case '2':
//                 Console.WriteLine(@$"nome: {nome[i]} 
//     origem: {origem[i]} 
//     Destino: {Destino[i]} 
//     Data do voo: {data[i]}.
//     Deseja sair? digite 0
//     ");
//     cadastrar = char.Parse(Console.ReadLine());
//     break;
//             case '0':
//                 break;

//             default:
//             Console.WriteLine($"Erro nos codigos digitados.");

//                 break;
//         }
// }




