/* Урок 3. Базовые алгоритмы. Продолжение  
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();
System.Console.WriteLine("Проверим, является ли число палиндромом.");
System.Console.Write("Введите пятизначное число: ");
string? txt = Console.ReadLine();
int number;  
if (int.TryParse(txt, out number))
{
    if (txt[0] == '-' && txt.Length == 6)
    {
        if (txt[1] == txt[5] && txt[2] == txt[4]) 
        {
            System.Console.WriteLine("Да, является.");
        }
        else
        {
            System.Console.WriteLine("Нет, не является.");
        }
    }
    else if (txt.Length == 5)
    {
        if (txt[0] == txt[4] && txt[1] == txt[3]) 
        {
            System.Console.WriteLine("Да, является.");
        }
        else
        {
            System.Console.WriteLine("Нет, не является.");
        }
    }
        else 
    {
        System.Console.WriteLine("Ошибка! В числе не 5 знаков");
    }
}
else
{
    Console.WriteLine("Ошибка! Это не число."); 
}