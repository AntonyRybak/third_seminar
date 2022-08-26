Console.Clear();
Console.Write("Введите координату x точки A ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y для точки А ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z для точки А ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату x точки B ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y для точки B ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z для точки B ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) + (Math.Pow(z2 - z1, 2)))));

