﻿// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

int firstDigit = int.Parse(Console.ReadLine());
int secondDigit = int.Parse(Console.ReadLine());
if (firstDigit / secondDigit == secondDigit)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}





