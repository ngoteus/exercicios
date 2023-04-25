using projeto_celular;

Console.WriteLine($"Qual a cor do celular?");
celular.cor = Console.ReadLine();
Celular celular = new Celular();



Console.WriteLine($"Qual o modelo do celular?");
celular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular?");
celular.tamanho = float.Parse(Console.ReadLine());

Console.WriteLine($"Voce quer ligar o celular?");
string resposta = Console.ReadLine(); 

    if(resposta = "sim")
    {
        celular.ligar()
    }
    else
    {
        celuar.desligar()
    }
    
while(celuar.ligado=true)
    {
    celular.ligacao();
    celular.mensagem();
    }