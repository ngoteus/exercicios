using projeto_celular;


Celular celular = new Celular();

Console.WriteLine($"Qual a cor do celular?");
celular.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do celular?");
celular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular?");
celular.tamanho = float.Parse(Console.ReadLine());

Console.WriteLine($"Voce quer ligar o celular? sim ou nao");
string resposta = Console.ReadLine(); 

    if (resposta == "sim")
{
    celular.ligar();
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

  
    
    
    
