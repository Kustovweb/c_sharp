Console.Clear();

Console.WriteLine("Расчет суммы от min до max");
Console.WriteLine("Введите min");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max");
int n = int.Parse(Console.ReadLine());

int GetNum(int m, int n) {
  int summ = 0;
  if (m == n) return m;
  else return summ =  summ + m + GetNum(m + 1, n);
}


Console.WriteLine($"{GetNum(m, n)}");