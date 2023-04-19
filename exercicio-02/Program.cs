Console.WriteLine($"Digite seu nome de usuario: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha: ");
string senha = Console.ReadLine();

while (nome == senha)
{
    Console.WriteLine($"A senha nao pode ser igual ao nome de usuario! Digite sua senha novamente: ");
    senha = Console.ReadLine();
}
Console.WriteLine($"Sua conta foi salva! ");