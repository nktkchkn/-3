// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int a1 = num / 10000;
int a2 = num / 1000 % 10;
int a4 = num / 10 % 10;
int a5 = num % 10;
// Console.WriteLine($"{a1} {a2} {a3} {a4} {a5}");
if (num <= 100000 && num >= 10000)
{
    if (a1 == a5 && a2 == a4)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}