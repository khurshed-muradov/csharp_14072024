﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
int tens = number / 10;
int units = number % 10;
if (tens > units)
{
    System.Console.WriteLine(number + " -> " + tens);
}
else
{
    System.Console.WriteLine(number + " -> " + units);
}




