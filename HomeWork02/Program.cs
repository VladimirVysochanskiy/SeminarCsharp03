/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
System.Console.Write("Введите координаты точки А через пробел (x y z): ");
string txtA = Console.ReadLine();
double[] a = txtA.Split().Select(double.Parse).ToArray();
System.Console.Write("Введите координаты точки B через пробел (x y z): ");
string txtB = Console.ReadLine();
double[] b = txtB.Split().Select(double.Parse).ToArray();

System.Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2))}");
System.Console.WriteLine();

//Знаю как сделать проверку ввода при вводе каждого значения отдельно.
//При вводе координат сразу по три, кода конечно меньше, но не разобрался пока как его проверять.
//Плюс не понял как убирать предупреждение "warning CS8602: Разыменование вероятной пустой ссылки."
//По всей видимости нужно прописать проверку на null значения.