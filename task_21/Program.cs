// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Cordinate(string message)
{
    System.Console.WriteLine(message);
    int im_cordanate = int.Parse(Console.ReadLine()!);
    return im_cordanate;
}

int x1 = Cordinate("Введите координату Х1: ");
int y1 = Cordinate("Введите координату Y1: ");
int x2 = Cordinate("Введите координату Х2: ");
int y2 = Cordinate("Введите координату Y2: ");

double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
System.Console.WriteLine(result);