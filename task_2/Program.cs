// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите цифру от 1 до 7 включительно: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (number == 2)
{
    System.Console.WriteLine("Вторник");
}
if (number == 3)
{
    System.Console.WriteLine("Среда");
}
if (number == 4)
{
    System.Console.WriteLine("Четверг");
}
if (number == 5)
{
    System.Console.WriteLine("Пятница");
}
if (number == 6)
{
    System.Console.WriteLine("Суббота");
}
if (number == 7)
{
    System.Console.WriteLine("Воскресенье");
}