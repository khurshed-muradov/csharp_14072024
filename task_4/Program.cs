// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
System.Console.WriteLine("Введите трехзначное число: ");
int digit = int.Parse(Console.ReadLine()!);
if (digit >= 100 && digit <= 999)
{
    System.Console.WriteLine(digit % 10);
}
else
{
    System.Console.WriteLine("Число не трехзначное!");
}
