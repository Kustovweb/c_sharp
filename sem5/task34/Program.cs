Console.Clear();

Console.WriteLine("Введите количество сгенерированных случайных чисел");
int rand = int.Parse(Console.ReadLine()!);
int[] arrRand = new int[rand];

int GetCountPositiveNum(int[] arrRand)
{
  for (int i = 0; i < arrRand.Length; i++)
  {
    arrRand[i] = new Random().Next(100, 1000);
  }
  int count = 0;
  foreach (var elem in arrRand)
  {
    if (elem % 2 == 0)
    {
      count++;
    }
  }
  return count;
}



Console.WriteLine($"Количество чётных чисел в массиве -> {GetCountPositiveNum(arrRand)}");
Console.WriteLine($"Массив -> [{string.Join(" ", arrRand)}]");