// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int Call(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int callNumber = Call("Введите число массива: ");

int[] arrNumber = new int[callNumber];
for (int i = 0; i < arrNumber.Length; i++)
{
    arrNumber[i] = new Random().Next(0, 2);

    System.Console.Write(arrNumber[i] + " ");
}
