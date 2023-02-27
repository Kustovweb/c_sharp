using System;
using static System.Console;

Clear();
WriteLine("Матрица m x n");
WriteLine("Введите m");
int m = int.Parse(ReadLine());
WriteLine("Введите n");
int n = int.Parse(ReadLine());
WriteLine("Введите min");
int min = int.Parse(ReadLine());
WriteLine("Введите max");
int max = int.Parse(ReadLine());

int[,] randArr = GetArray(m, n, min, max);
PrintArray(randArr);
WriteLine("*****");
SortElRow(randArr);
PrintArray(randArr);

void SortElRow(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int t = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = t;
        }
      }

    }
  }
}


int[,] GetArray(int m, int n, int min, int max)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(min, max + 1);
    }
  }
  return result;
}


void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}