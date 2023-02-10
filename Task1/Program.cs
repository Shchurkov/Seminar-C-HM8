// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int e = 0; e < arr.GetLength(1) - 1; e++)
        {
            if (arr[i, e] < arr[i, e + 1])
            {
                int temp = arr[i, e + 1];
                arr[i, e + 1] = arr[i, e];
                arr[i, e] = temp;
            }
        }

    }

}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}