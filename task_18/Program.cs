// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

int Cordinate(string message)
{
    System.Console.WriteLine(message);
    int im_cordanate = int.Parse(Console.ReadLine()!);
    return im_cordanate;
}

void FindQuarter(int a)
{
    if (a == 1)
    {
        System.Console.WriteLine("X = (0; +n),  Y = (0; +n)");
    }
    if (a == 2)
    {
        System.Console.WriteLine("X = (0; -n),  Y = (0; +n)");
    }
    if (a == 3)
    {
        System.Console.WriteLine("X = (0; -n),  Y = (0; -n)");
    }
    if (a == 4)
    {
        System.Console.WriteLine("X = (0; +n),  Y = (0; -n)");
    }
}
int quater = Cordinate("Введит четверть: ");
FindQuarter(quater);
