// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int Call(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int Times(int callNumber)
{
    int count = 0;
    for (count = 0; callNumber > 0; count++)
    {
        callNumber = callNumber / 10;
    }
    return count;
}
int callNumber = Call("Введите число: ");
int times = Times(callNumber);
System.Console.WriteLine($"Количество цифр в числе {callNumber} = {times}");