using System;
using static System.Console;

Clear();

const int M = 4;
const int N = 4;

int[,] randArr = GetArray(M, N, 1, 10);

PrintArray(randArr);
WriteLine("*****");
GetMinValue(GetSummRow(randArr));


int[] GetSummRow(int[,] arr) {
  int[] res = new int[arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++) {
    int summ = 0;
    for (int j = 0; j < arr.GetLength(1); j++) {
      summ += arr[i, j];
      res[i] = summ;
    }
  }
  return res;
}

void GetMinValue(int[] arr) {
  int min = arr[0];
  int idx = 0;
  for (int i = 1; i < arr.Length - 1; i++) {
    if (arr[i] < min) {
      min = arr[i];
      idx = i;
    }
  }
  WriteLine($"Массив с суммами: {String.Join(", ", arr)}");
  WriteLine($"Номер строки в матрице с мин суммой: {idx + 1}");
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