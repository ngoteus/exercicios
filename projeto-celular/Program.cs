using projeto_celular;


Celular celular = new Celular();

Console.WriteLine($"Qual a cor do celular?");
celular.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do celular?");
celular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular?");
celular.tamanho = float.Parse(Console.ReadLine());

<<<<<<< HEAD
Console.WriteLine($"Voce quer ligar o celular?");
celular.ligado = Console.ReadLine() == "sim";
=======
Console.WriteLine($"Voce quer ligar o celular? sim ou nao");
string resposta = Console.ReadLine(); 
>>>>>>> 1ce3d968c45048f1ea48b18d8bdce03949e04a61

    if (resposta == "sim")
{
    celular.ligar();
<<<<<<< HEAD
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
=======
Console.WriteLine($"Voce quer fazer ligacao? sim ou nao");
string resposta2 = Console.ReadLine();
if (resposta2 == "sim")
{
     celular.ligacao();
     
}
Console.WriteLine($"Voce quer enviar mensagem? sim ou nao");
    string resposta3 = Console.ReadLine();
    if (resposta3 == "sim")
    {
        celular.mensagem();
    }
    Console.WriteLine($"Voce quer Desligar? sim ou nao");
string resposta4 = Console.ReadLine();
if (resposta4 == "sim")
{
    celular.desligar();
}
}

  
    
    
    
>>>>>>> 1ce3d968c45048f1ea48b18d8bdce03949e04a61
