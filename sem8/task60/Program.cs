using System;
using static System.Console;

Clear();

PrintArray(GetArray(2, 2, 2));


int[,,] GetArray(int m, int n, int p)
{
  int[,,] result = new int[m, n, p];
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      for (int k = 0; k < result.GetLength(2); k++) {
        result[i, j, k] = new Random().Next(10, 99 + 1);
      }
    }
  }
  return result;
}


void PrintArray(int[,,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++) // Страницы
  {
   
    for (int j = 0; j < inArray.GetLength(1); j++) // Строки
    
    {
     for (int k = 0; k < inArray.GetLength(2); k++) {  // Колонки
       Write($"{inArray[i, j, k]} ({i}{j}{k}) ");

     }
     WriteLine("");
    }
  }
}