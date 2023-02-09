/*
Задача 27: Напишите программу,
которая принимает на вход число и выдаёт сумму цифр в числе.
*/

Console.Clear();

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");

int GetSumm(int num)
{
  int result = 0;

  while (num > 0)
  {
    result += num % 10;
    num /= 10;
  }
  return result;
}


Console.WriteLine($"{GetSumm(a)}");
