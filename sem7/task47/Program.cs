using System;
using static System.Console;

WriteLine("Введите количество строк в массиве:> ");
int rows = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов в массиве:> ");
int columns = int.Parse(ReadLine()!);

WriteLine("Введите минимальное число в массиве :> ");
double min = double.Parse(ReadLine()!);
WriteLine("Введите максимальное число в массиве :> ");
double max = double.Parse(ReadLine()!);


PrintArray(GetArray(rows, columns, min, max));


double[,] GetArray(int m, int n, double min, double max)
{
double[,] result = new double[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
result[i, j] = new Random().NextDouble() * (max - min) + min;
}
}
return result;
}

void PrintArray(double[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Write($"{inArray[i,j]:f1} ");
}
WriteLine();
}
}
