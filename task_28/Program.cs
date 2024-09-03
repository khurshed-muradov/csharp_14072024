// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int CallNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int Product(int callNumber)
{
    int product = 1; // Инициализируется счетчик произведения чисел от 1 до N.
    for (int i = 1; i <= callNumber; i++)
    {
        product = i * product;
    }
    return product;
}

int callNumber = CallNumber("Введите число: ");
int product = Product(callNumber);
System.Console.WriteLine(product);