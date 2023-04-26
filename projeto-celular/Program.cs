using projeto_celular;

Celular celular = new Celular();

Console.WriteLine($"Qual a cor do celular?");
celular.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do celular?");
celular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular?");
celular.tamanho = float.Parse(Console.ReadLine());

Console.WriteLine($"Voce quer ligar o celular?");
celular.ligado = Console.ReadLine() == "sim";

if (celular.ligado)
{
    celular.ligar();
    Console.WriteLine(@$"
    Deseja fazer uma ligacao? 
    's' para sim
    'n' para nao
    ");
    string resposta = Console.ReadLine();
    if (resposta == "s")
    {
        celular.ligacao();
        Console.WriteLine(@$"
         Deseja enviar uma mensagem 
         's' para sim
         'n' para nao");
        string resposta2 = Console.ReadLine();
        if (resposta2 == "s")
    {
        celular.mensagem();
        Console.WriteLine(@$"
            Deseja desligar o celular
            's' para sim
            
    ");
        string resposta3 = Console.ReadLine();
        if (resposta3 == "s")
            {
                celular.desligar();
            }

    }
    else
    {
        Console.WriteLine(@$"
            Deseja desligar o celular
            's' para sim
            
    ");
        string resposta3 = Console.ReadLine();
        if (resposta3 == "s")
            {
                celular.desligar();
            }
    }


    }
    else
    {
        Console.WriteLine(@$"
        Deseja enviar uma mensagem
        's' para sim
        'n' para nao"
    );
    string resposta2 = Console.ReadLine();
    if (resposta2 == "s")
    {
        celular.mensagem();
        Console.WriteLine(@$"
            Deseja desligar o celular
            's' para sim
            
    ");
        string resposta3 = Console.ReadLine();
        if (resposta3 == "s")
            {
                celular.desligar();
            }

    }
    else
    {
        Console.WriteLine(@$"
            Deseja desligar o celular
            's' para sim
            
    ");
        string resposta3 = Console.ReadLine();
        if (resposta3 == "s")
            {
                celular.desligar();
            }
    }

    }
    
    
    



}