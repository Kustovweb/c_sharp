using System;
Console.Clear();

Console.WriteLine("Программа вычисления функции Аккермана");
Console.WriteLine("Введите m");

int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n");

int n = int.Parse(Console.ReadLine());


int Ackermann(int m, int n) {
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Ackermann(m - 1, 1);
  if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
  return Ackermann(m, n);
}

Console.WriteLine($"{Ackermann(m, n)}");