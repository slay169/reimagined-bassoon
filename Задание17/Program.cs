// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Это исправленный вариант с double и округлением до двух знаков !!!!

double[] numbers = new double[8];

Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(10, 99) + new Random().NextDouble();
    numbers[i] = Math.Round(numbers[i], 2);

    Console.Write(" ");
    Console.Write(numbers[i]);
}
Console.Write("]");

double max = numbers[0];
double min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.Write(" Разница между максимальным и минимальным элементов массива: ");
Console.WriteLine(Math.Round(max - min, 2));
