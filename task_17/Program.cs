﻿// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

// void GetResult(int X, int Y)
// {
//     if (X > 0 && Y > 0)
//     {
//         System.Console.WriteLine("I четверть");
//     }
//     if (X < 0 && Y > 0)
//     {
//         System.Console.WriteLine("II четверть");
//     }
//     if (X < 0 && Y < 0)
//     {
//         System.Console.WriteLine("III четверть");
//     }
//     if (X > 0 && Y < 0)
//     {
//         System.Console.WriteLine("IV четверть");
//     }
// }

string GetResult(int X, int Y)
{
    string res = "";
    if (X > 0 && Y > 0)
    {
        res = "I четверть";
    }
    if (X < 0 && Y > 0)
    {
        res = "II четверть";
    }
    if (X < 0 && Y < 0)
    {
        res = "III четверть";
    }
    if (X > 0 && Y < 0)
    {
        res = "IV четверть";
    }
    return res;
}

int x = Prompt("Введите точку X: ");
int y = Prompt("Введите точку Y: ");
if (x != 0 && y != 0)
{
    Console.WriteLine(GetResult(x, y));
}
else
{
    System.Console.WriteLine("Неверный формат данных!");
}
