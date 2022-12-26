/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
System.Console.Write("Введите число: ");
string? txt = Console.ReadLine();
int number;  
if (int.TryParse(txt, out number))
{
    if (number < 0)
    {
        for (int i = 1; i >= number; i--)
        {
            System.Console.Write($"{Math.Pow(i, 3)} ");
        }
    }
    else
    {
        for (int i = 1; i <= number; i++)
        {
            System.Console.Write($"{Math.Pow(i, 3)} ");
        }
    }
}
else
{
    Console.WriteLine("Ошибка! Это не число."); 
}