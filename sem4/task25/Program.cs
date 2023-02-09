/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
*/

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine() ?? "0");

int GetCube(int x, int n)
{
  int result = 1;
  for (int i = 0; i < n; result *= x, i++) ;
  return result;
}

Console.WriteLine($"{GetCube(a, b)}");
