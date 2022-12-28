//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = new int[8];

Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(10, 99);
    Console.Write(" ");
    Console.Write(numbers[i]);
}
Console.Write("]");

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + numbers[i];
    }
}
Console.Write(" Сумма чисел на нечетных позициях: ");
Console.WriteLine(sum);


