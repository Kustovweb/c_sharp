using System;
using static System.Console;

Clear();

const int M = 4;
const int N = 4;
WriteLine("Матрица 4x4");
WriteLine("Введите номер строки");
int row = int.Parse(ReadLine());
WriteLine("Введите номер столбца");
int column = int.Parse(ReadLine());
int[,] mass = GetArray(M, N);
PrintArray(mass);

WriteLine(CheckValue(GetNumValue(row, column, mass)) 
    ? "Ваше число: >>> " + GetNumValue(row, column, mass) 
    : "Число не найдено");


bool CheckValue(int check)
{
  if (check != 0)
  {
    return true;
  }
  return false;

}

int GetNumValue(int row, int col, int[,] arr)
{
  int result = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (row == i && col == j)
      {
        result = arr[i, j];
      }
    }
  }
  return result;
}


int[,] GetArray(int m, int n)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(1, 9 + 1);
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