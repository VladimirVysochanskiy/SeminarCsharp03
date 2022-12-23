int[] point = new int[2];
System.Console.Write("Введите координату X: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
point[1] = Convert.ToInt32(Console.ReadLine());
if (point[0] > 0 && point[1] > 0)
{
    System.Console.WriteLine("Точка лежит в первой четверти.");
}
else if (point[0] < 0 && point[1] > 0)
{
    System.Console.WriteLine("Точка лежит во второй четверти.");
}
else if (point[0] < 0 && point[1] < 0)
{
    System.Console.WriteLine("Точка лежит в третей четверти.");
}
else if (point[0] > 0 && point[1] < 0)
{
    System.Console.WriteLine("Точка лежит в четвертой четверти.");
}
else
{
    System.Console.WriteLine("Точка лежит на оси");
}