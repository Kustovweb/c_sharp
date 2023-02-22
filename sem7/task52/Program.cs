using System;
using static System.Console;

Clear();
WriteLine("Введите размер матрицы");
WriteLine("Введите количество строк:");
int rows = int.Parse(ReadLine());
WriteLine("Введите количество столбцов:");
int cols = int.Parse(ReadLine());
int[,] randArray = GetArray(rows, cols, 0, 10);
PrintArray(randArray);
GetAverage(randArray);


void GetAverage(int[,] arr) {
  double[] avr = new double[arr.GetLength(1)];
  double summ;
  for (int i = 0; i < arr.GetLength(1); i++) {
     summ = 0;
    for (int j = 0; j < arr.GetLength(0); j++) {
      summ += arr[j, i];
      avr[i] = summ / arr.GetLength(0);
    }
  }
  foreach(double elem in avr) {
    if (elem == Math.Truncate(elem)) {
      Write($"{elem}; ");
    }
    else {
      Write($"{elem:f1}; ");
    }
  }
}

int[,] GetArray(int rows, int cols, int min, int max)
{
int[,] result = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < cols; j++)
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
Write($"{inArray[i,j]} ");
}
WriteLine();
}
}