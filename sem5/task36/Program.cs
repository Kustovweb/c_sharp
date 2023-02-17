Console.Clear();
Console.WriteLine("Введите количество случайных чисел");
int num = int.Parse(Console.ReadLine()!);
int[] arrRand = new int[num];
Console.WriteLine("Введите диапазон случайных чисел");
Console.WriteLine("От: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("До: ");
int maxValue = int.Parse(Console.ReadLine()!);


int GetSummElementsArr(int[] arr, int min, int max)
{

  for (int i = 0; i < arrRand.Length; i++)
  {
    arrRand[i] = new Random().Next(min, max + 1);
  }
  int count = 0;
  for (int i = 0; i < arrRand.Length; i++)
  {
    if (i % 2 != 0)
    {
      count += arrRand[i];
    }
  }
  return count;
}

Console.WriteLine($"Сумма элементов с нечетными индексами: {GetSummElementsArr(arrRand, minValue, maxValue)}");
Console.WriteLine($"Массив -> [{string.Join(" ", arrRand)}]");
