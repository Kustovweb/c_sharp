Console.Clear();
Console.WriteLine("Является ли число четным? >>>");
Console.WriteLine("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(num % 2 == 0 ? "Четное" : "Нечетное");

