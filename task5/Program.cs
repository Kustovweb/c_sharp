Console.Clear();

Console.WriteLine("Введите трехзначное число: >>>");
int num = int.Parse(Console.ReadLine());
int num1 = (num / 10);

Console.WriteLine($"{num} -> {num1 % 10}");