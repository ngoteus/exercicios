using projeto_celular;

Celular celular = new Celular();

Console.WriteLine($"Qual a cor do celular?");
celular.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do celular?");
celular.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular?");
celular.tamanho = float.Parse(Console.ReadLine());

Console.WriteLine($"Voce quer ligar o celular?");
celular.ligado = Console.ReadLine()=="sim";

if (celular.ligado)
{
    celular.ligar();
    celular.ligacao();
    celular.mensagem();
    celular.desligar();
}