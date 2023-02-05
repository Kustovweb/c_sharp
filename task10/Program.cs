Console.Clear();

Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());


for (int i = 1; i <= N; i++) {
  Console.WriteLine($"{Math.Pow(i, 3)}");
}