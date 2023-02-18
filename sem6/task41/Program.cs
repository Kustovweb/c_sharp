Console.Clear();

Console.WriteLine("Введите числа через пробел");
string strNum = Console.ReadLine()!;
int[] GetArrayFromString(string stringArray) {
  string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
  int[] res = new int[nums.Length];

  for (int i = 0; i < nums.Length; i++) {
      res[i] = int.Parse(nums[i]);
  }
  return res;
}

int GetCountPositive(int[] arr) {
  int count = 0;
  for (int i = 0; i < arr.Length; i++) {
    if (arr[i] > 0) {
      count++;
    }
  }
  return count;
}

Console.WriteLine($"{GetCountPositive(GetArrayFromString(strNum))}");