
Console.Clear();

Console.WriteLine("Введите число >>>");

string str = Convert.ToString(Console.ReadLine());

if (str.Length < 3)
{
  Console.WriteLine("Третьей цифры нет");
  return;
}
Console.WriteLine(str[2]);