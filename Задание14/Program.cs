//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] numbers = new int[8];

Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 1000);
    Console.Write(" ");
    Console.Write(numbers[i]);
}
Console.Write("]");

int evenCount = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenCount = evenCount + 1;
    }
}
Console.Write(" Кол-во четных чисел в массиве: ");
Console.Write(evenCount);
