//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
double[] a = new double[2];
double[] b = new double[2];
System.Console.Write("Введите координату X для первой точки: ");
a[0] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату Y для первой точки: ");
a[1] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату X для второй точки: ");
b[0] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату Y для второй точки: ");
b[1] = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2))}");