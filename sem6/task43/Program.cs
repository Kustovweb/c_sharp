Console.Clear();

Console.WriteLine("Введите значения точек через enter");
Console.WriteLine("Введите b1");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = int.Parse(Console.ReadLine());
const int x = 0;
const int y = 1;
double[] GetIntersectionPoint(double b1, double k1, double b2, double k2) {
  double[] coord = new double[2];
   coord[x] = (b2 - b1) / (k1 - k2);
   coord[y] = k2 * coord[x] + b2;
  return coord;
}

Console.WriteLine($"({String.Join(", ", GetIntersectionPoint(b1, k1, b2, k2))})");
