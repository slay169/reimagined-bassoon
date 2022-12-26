int[] array = new int[8];

for (int x = 0; x < array.Length; x = x + 1)
{
    array[x] = new Random().Next(-10, 10);
    Console.Write(" ");
    Console.Write(array[x]);
}

