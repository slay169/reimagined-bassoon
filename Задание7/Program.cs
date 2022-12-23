Console.WriteLine("Введите число от 1 до 7:");
int number = Int32.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("День выходной!");
}
else
{
  Console.WriteLine("День будний!");  
}
