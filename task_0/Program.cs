// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
System.Console.Write("Введите число: ");
int digit = int.Parse(Console.ReadLine());
int result = digit * digit;
System.Console.WriteLine("Квадрат числа: " + digit + " = " + result);
