Console.Clear();
Console.WriteLine("Введите число: >>>");
long num = Convert.ToInt64(Console.ReadLine());
int i = 2;
while (i <= num)
{
  Console.WriteLine($"{i}");
  i += 2;
}

