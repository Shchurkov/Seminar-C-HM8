// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


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


int minRow = 0;
int minSumRow = 0;
int sumRow = 0;
for (int i = 0; i < arr.GetLength(1); i++)
{
    minRow += arr[0, i];
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++) sumRow += arr[i, j];
    if (sumRow < minRow)
    {
        minRow = sumRow;
        minSumRow = i;
    }
    sumRow = 0;
}
Console.Write($"{minSumRow + 1} строка");

