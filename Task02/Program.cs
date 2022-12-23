//Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).

Console.Clear();
System.Console.Write("Введите номер четверти: ");
int flat = Convert.ToInt32(Console.ReadLine());
string[] part = {"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};
if (flat == 1)
{
    System.Console.WriteLine($"Для указанной четверти возможны следующие координаты: {part[0]}");
}
else if (flat == 2)
{
    System.Console.WriteLine($"Для указанной четверти возможны следующие координаты: {part[1]}");
}
else if (flat == 3)
{
    System.Console.WriteLine($"Для указанной четверти возможны следующие координаты: {part[2]}");
}
else if (flat == 4)
{
    System.Console.WriteLine($"Для указанной четверти возможны следующие координаты: {part[3]}");

}
else
{
    System.Console.WriteLine("В двухмерном пространстве только 4 плоскости координат");
}