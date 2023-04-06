Console.WriteLine($"Digite um numero inteiro para saber sua tabuada.");
int numero = int.Parse(Console.ReadLine());

// int numero = 1;
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero}x{i}={numero*i}");
    
}
