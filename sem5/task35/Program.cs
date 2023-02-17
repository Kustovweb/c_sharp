Console.Clear();

int[] arrRand = new int[123];

int GetCountNum(int[] arr) {
  int count = 0;
  Random rand = new Random();
  for (int i = 0; i < arr.Length; i++) {
    arr[i] = rand.Next(0, 1000 + 1);
  }
  foreach (var elem in arr) {
    if (elem >= 10 && elem <= 99) {
      count += 1;
    }
  }
  return count;
}


Console.WriteLine($"Количество элементов массива: {GetCountNum(arrRand)}");
Console.WriteLine($"Массив: [{string.Join(", ", arrRand)}]");