Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
if(i % 2 == 0)
{
    Console.WriteLine($"Число {i} является четным");
}
else
{
    Console.WriteLine($"Число {i} является нечетным");
}