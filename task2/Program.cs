Console.Clear();
Console.WriteLine("Сравнить 3 числа >>>");
Console.WriteLine("Введите число 1 :");
long a = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число 2 :");
long b = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число 3 :");
long c = Convert.ToInt64(Console.ReadLine());

long max = a;

if (max < b)
{
  max = b;
}
if (max < c)
{
  max = c;
}

Console.WriteLine($"Максимальное число: {max}");
