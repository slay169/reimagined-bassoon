Console.WriteLine("Введите число a: ");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Степень b: ");
int b = Int32.Parse(Console.ReadLine());

int c = a;

for (int i = 1; i < b; i = i+1)
{
c = c * a;
}
Console.WriteLine($"a в степени b равно: {c}");

