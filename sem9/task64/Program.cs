using System;
using static System.Console;

WriteLine("Введите число");
int num = int.Parse(ReadLine());

string GetNum(int n) {
  string s = String.Empty;
  return n == 1 ? "1" : s = n.ToString() + " " + GetNum(n - 1);
}

WriteLine($"{GetNum(num)}");