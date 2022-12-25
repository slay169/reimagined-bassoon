Console.WriteLine("Введите 5ти значное число:");
//int number = Int32.Parse(Console.ReadLine());
var number = Console.ReadLine();

if (number.Length != 5)
{
    Console.WriteLine("Число не пятизначное! Введите верное число.");
    return;
}

var reversedNumber = new string(number.Reverse().ToArray());

if (reversedNumber == number)
{
    Console.WriteLine("Число палиндром!");
}
else
{
    Console.WriteLine("Число не палиндром");
}

