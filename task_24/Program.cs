// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}


void GetNumberSum(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    System.Console.WriteLine($"Cумма чисел от 1 до {a} = {sum}");
}
int A = GetNumber("Введите число: ");
GetNumberSum(A);
