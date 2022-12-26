Console.WriteLine("Введите число");
string number = Console.ReadLine();

int result = 0;
for (int i = 0; i < number.Length; i = i + 1)
{
    result = result + Int32.Parse(number[i].ToString());
}

Console.WriteLine(result);


