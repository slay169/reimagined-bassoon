// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[, ] matrix = new int[3, 4];
matrix = FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool IsNumberInMatrix = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == number)
        {
            IsNumberInMatrix = true;
            Console.Write("Число стоит на месте с индексом: " + Convert.ToInt32(i) + ", ");
            // Console.Write(Convert.ToInt32(i) + ", ");
            Console.WriteLine(Convert.ToInt32(j));
        }
    }
}

if (IsNumberInMatrix)
{
    Console.WriteLine($"Число {number} есть в массиве");
}
else
{
    Console.WriteLine($"Числа {number} нет в массиве");
}