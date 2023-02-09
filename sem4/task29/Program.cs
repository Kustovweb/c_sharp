/*
Задача 29: Напишите программу,
которая задаёт массив из 8 элементов и выводит их на экран.
*/

Console.Clear();
int a = int.Parse(Console.ReadLine() ?? "0");
int[] array = GetRandomArray(a);
Console.Write($"[");
for (int i = 0; i < a - 1; i++)
{
  Console.Write($"{array[i]}, ");

}
Console.Write($"{array[a - 1]}]");

int[] GetRandomArray(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  {
    arr[i] = new Random().Next(1, 100);
  }
  return arr;
}