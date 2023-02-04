Console.Clear();

Console.WriteLine("Введите пятизначное число >>>");
int number = int.Parse(Console.ReadLine());
int temp = number;
int five = temp % 10;
int four = temp % 100 / 10;

while (number > 100)
{
  number /= 10;
}

int two = number % 10;
int one = number / 10;

if (one == five && two == four)
{
  Console.WriteLine($"Число: {temp} является палиндромом");
}
else
{
  Console.WriteLine($"{temp} не является палиндромом");
}

