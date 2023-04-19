Console.WriteLine($"Digite sua nota de um a dez");
int nota = int.Parse(Console.ReadLine());

while (nota <0 || nota >10)
{
    Console.WriteLine($"Sua nota e invalida! ");
    nota = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Sua nota e valida! ");


