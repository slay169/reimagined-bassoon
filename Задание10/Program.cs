Console.WriteLine("Введите число:");
int N = Int32.Parse(Console.ReadLine());
int x = 1;

while (x <= N)
{
    Console.Write(" ");
    Console.Write(x * x * x);
    x = x + 1;
}

