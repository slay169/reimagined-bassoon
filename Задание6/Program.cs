Console.WriteLine("Введите число:");
int number = Int32.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
    return;
}

Console.WriteLine("Третья цифра числа:");
Console.WriteLine(number.ToString()[2]);
