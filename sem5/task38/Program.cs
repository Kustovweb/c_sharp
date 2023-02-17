Console.Clear();

double[] arr = new double[5] { 3, 7, 22, 2, 78 };

double GetDiffMaxMin(double[] arr)
{
  double min = arr[0];
  double max = arr[1];
  foreach (var elem in arr)
  {
    if (max < elem)
    {
      max = elem;
    }
    if (min > elem)
    {
      min = elem;
    }
  }
  double diff = max - min;
  return diff;
}

Console.WriteLine($"{GetDiffMaxMin(arr)}");