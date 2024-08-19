// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int GetSquare(string message)
{
    System.Console.Write(message + " ");
    int im_getSquare = int.Parse(Console.ReadLine()!);
    return im_getSquare;
}

int n = GetSquare("Введите число:");

for (int i = 1; i <= n; i++)
{
    System.Console.Write((i * i) + " ");
}