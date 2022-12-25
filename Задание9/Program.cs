Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z:");
double z = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x1:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z1:");
double z1 = double.Parse(Console.ReadLine());

double xy = Math.Pow(x-x1, 2);
double xy1 = Math.Pow(y-y1, 2);
double zz1 = Math.Pow(z-z1, 2);
double s = Math.Sqrt(xy+xy1+zz1);

Console.WriteLine($"Расстояние между точками: {s}");
