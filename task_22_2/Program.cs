// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int GetNumber(string message)
{
    System.Console.Write(message + " ");
    int im_getNumber = int.Parse(Console.ReadLine()!);
    return im_getNumber;
}

void GetSquare(int n)
{
    int count = 1;
    while (count <= n)
    {
        if (count == n)
        {
            System.Console.WriteLine(count * count);
        }
        else
        {
            System.Console.Write(count * count + " ");
        }
        count++;
    }
}
int n = GetNumber("Введите число:");
GetSquare(n);
