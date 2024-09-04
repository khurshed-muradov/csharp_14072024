// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int Call(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] RandomArray(int callNumber)
{
    int[] arrNumber = new int[callNumber];
    Random rnd = new Random();
    for (int i = 0; i < arrNumber.Length; i++)
    {
        arrNumber[i] = rnd.Next(0, 2);
    }
    return arrNumber;
}

void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        System.Console.Write(element + " ");
    }
}

int callNumber = Call("Введите число массива: ");
int[] randomArray = RandomArray(callNumber);
System.Console.Write("\nСгенерированный массив: ");
PrintArray(randomArray);