using System;
using static System.Console;

Clear();
 const int n = 4;
int[,] SpiralArr = new int[n, n];
PrintArray(SpiralArrayNum(SpiralArr));

int[,] SpiralArrayNum(int[,] arr) {
  int k = 1;
  int j = 0;
  int i = 0;
  while(k <= n * n) {
    arr[i, j] = k;
    k++;
    if (i <= j + 1 && i + j < n - 1) {
      j++;
    }
    else if (i < j && i + j >= n - 1) {
      i++;
    }
    else if (i >= j && i + j > n - 1) {
      j--;
    }
    else {
      i--;
    }
  }
  return arr;
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