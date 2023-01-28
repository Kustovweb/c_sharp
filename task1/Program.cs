// Задача 2
Console.WriteLine("Введите первое число");
long a = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите второе число");
long b = Convert.ToInt64(Console.ReadLine());



if (a > b)
{
  Console.WriteLine("Максимальное число: " + a);
  Console.WriteLine("Минимальное число: " + b);
}
else if (a < b)
{
  Console.WriteLine("Максимальное число: " + b);
  Console.WriteLine("Минимальное число: " + a);

}
else

{
  Console.WriteLine($"Числа {a} и {b} равны");
}