Console.WriteLine("Введите два числа: ");
string userNumber1 = Console.ReadLine();
string userNumber2 = Console.ReadLine();
int number1 = int.Parse(userNumber1);
int number2 = int.Parse(userNumber2);
if(number1 < number2)
{
    Console.WriteLine($"Число {number1} меньше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}