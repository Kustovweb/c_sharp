Console.Clear();
Console.WriteLine("Введите цифры через пробел");
string strNum = Console.ReadLine()!;
int[] GetArrayFromString(string stringArray) {
  string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
  int[] res = new int[nums.Length];

  for (int i = 0; i < nums.Length; i++) {
      res[i] = int.Parse(nums[i]);
  }
  return res;
}



int[] GetMultPairArr(int[] arr) {
    bool isInt = arr.Length % 2 == 0 ? true : false;
    int[] result = new int[isInt ? arr.Length / 2 : (arr.Length / 2) + 1];
    for (int i = 0; i < arr.Length / 2; i++) {
      result[i] = arr[i] * arr[arr.Length - i - 1];
     if (!isInt) {
      result[arr.Length/2] = arr[(arr.Length - 1) / 2];
     }
    }
    return result;
}

Console.WriteLine($"[{String.Join(", ", GetMultPairArr(GetArrayFromString(strNum)))}]");