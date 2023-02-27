using System;
using static System.Console;

Clear();
WriteLine("Матрица m x n");
WriteLine("Введите m");
int m = int.Parse(ReadLine());
WriteLine("Введите n");
int n = int.Parse(ReadLine());
WriteLine("Введите количество столбцов 2 матрицы");
int col = int.Parse(ReadLine());
WriteLine("Введите min");
int min = int.Parse(ReadLine());
WriteLine("Введите max");
int max = int.Parse(ReadLine());

int[,] randArr1 = GetArray(m, n, min, max);
int[,] randArr2 = GetArray(n, col, min, max);
WriteLine("Матрица 1");
PrintArray(randArr1);
WriteLine("Матрица 2");
PrintArray(randArr2);
WriteLine("Произведение матрицы 1 и матрицы 2");
PrintArray(MultiplyArr(randArr1, randArr2));

int[,] MultiplyArr(int[,] arrA, int[,] arrB) {
    int[,] arrC = new int[m, col];

  for (int i = 0; i < arrC.GetLength(0); i++) {
    for (int j = 0; j < arrC.GetLength(1); j++) {
      arrC[i, j] = 0;
      for (int k = 0; k < arrA.GetLength(1); k++) {
         arrC[i, j] =  arrC[i, j] +  arrA[i, k] * arrB[k, j];
      }
    }
  }
  return arrC;
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