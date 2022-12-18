Console.Clear();
Console.Write("Введите X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double dist1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double dist2 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
double dist3 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine(Math.Round(dist, 2));