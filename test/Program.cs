// Random random = new Random();

// int randomNumber1 = random.Next(1, 10);
// System.Console.WriteLine(randomNumber1);

// int randomNumber2 = random.Next(10, 100);
// System.Console.WriteLine(randomNumber2);

// int randomNumber3 = random.Next(100, 1000);
// System.Console.WriteLine(randomNumber3);

// 1. Напиши программу, которая генерирует и выводит на экран 10 случайных чисел в диапазоне от 1 до 100.

// Подсказка:
// Используй метод rnd.Next(minValue, maxValue).

// int CallNumber(message)
// {
//     System.Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int callNumber = CallNumber("Введите число: ");

// Random rnd = new Random();

// int randomNumber1 = rnd.Next(0, 10);
// System.Console.WriteLine(randomNumber1);

// for (int i = 0; i < 5; i++)
// {
//     int randomNumber2 = rnd.Next(0, 100);
//     if (i == 4)
//     {
//         System.Console.Write(randomNumber2);
//     }
//     else
//     {
//         System.Console.Write(randomNumber2 + ", ");
//     }
// }

// Random rnd = new Random();
// for (int i = 0; i < 5; i++)
// {
//     int randomN = rnd.Next(11, 21);
//     if (i == 4)
//     {
//         System.Console.Write(randomN);
//     }
//     else
//     {
//         System.Console.Write(randomN + ", ");
//     }
// }

// Задача 1: Генерация одной случайной цифры
// Описание:
// Напиши программу, которая выводит одну случайную цифру от 0 до 9.

// Random rnd = new Random();
// int randomDigit = rnd.Next(0, 10);
// System.Console.WriteLine(randomDigit);

// Задача 2: Генерация нескольких случайных цифр
// Описание:
// Напиши программу, которая генерирует и выводит на экран 5 случайных цифр от 0 до 9.

// Random rnd = new Random();
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     System.Console.Write(randomDigit + " ");
// }

// Задача 3: Чётные и нечётные цифры
// Описание:
// Напиши программу, которая генерирует 10 случайных цифр от 0 до 9 и выводит их в две категории: 
// чётные и нечётные.

// Random rnd = new Random();
// List<int> evenNumbers = new List<int>();
// List<int> oddNumbers = new List<int>();
// for (int i = 0; i < 10; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     if (randomDigit % 2 == 0)
//     {
//         evenNumbers.Add(randomDigit);
//     }
//     else
//     {
//         oddNumbers.Add(randomDigit);
//     }
// }
// System.Console.WriteLine("Четные: " + string.Join(", ", evenNumbers));
// System.Console.WriteLine("Нечетные: " + string.Join(", ", oddNumbers));

// Задача 4: Максимальная цифра
// Описание:
// Напиши программу, которая генерирует 5 случайных цифр от 0 до 9 и выводит на экран самую большую из них.

// Random rnd = new Random();
// int max = 0;
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 9);
//     System.Console.Write(randomDigit + " ");
//     if (randomDigit > max)
//     {
//         max = randomDigit;
//     }
// }
// System.Console.WriteLine("\nМаксимальная: " + max);

// Задача 5: Сумма случайных цифр
// Описание:
// Напиши программу, которая генерирует 5 случайных цифр от 0 до 9 и выводит их сумму.

// Random rnd = new Random();

// int sum = 0;

// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     System.Console.Write(randomDigit + " ");
//     sum = sum + randomDigit;
// }
// System.Console.WriteLine("\nСумма: " + sum);

// Задача 6: Определение одинаковых цифр
// Описание:
// Напиши программу, которая генерирует 5 случайных цифр от 0 до 9 и проверяет, есть ли среди них одинаковые.

// Random rnd = new Random();
// List<int> digits = new List<int>();
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     System.Console.Write(randomDigit + " ");
//     digits.Add(randomDigit);
// }
// bool hasDuplicates = digits.GroupBy(x => x).Any(g => g.Count() > 1);
// System.Console.WriteLine("\nЕсть одинаковые цифры: " + (hasDuplicates ? "Да" : "Нет"));

// int[] numbers = new int[5];
// numbers[0] = 10;
// numbers[1] = 20;
// numbers[2] = 30;
// numbers[3] = 40;
// numbers[4] = 50;
// System.Console.Write(numbers[0]);

// int[] numbers = { 1, 2, 3, 4, 5 };
// System.Console.WriteLine(numbers[4]);

// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20 };
// int length = numbers.Length;
// System.Console.WriteLine(length);

// int[] numbers = { 10, 26, 35, 76, 36, 86, 34 };
// int length = numbers.Length;
// for (int i = 0; i < length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

// int[] numbers = { 32, 54, 34, 765, 234, 876, 234, 6545 };
// int length = numbers.Length;
// for (int i = 0; i < length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

// Задача 1: Создание и вывод массива
// Описание:
// Напиши программу, которая создаёт массив из 5 целых чисел и выводит их на экран.

// int[] numbers = { 1, 4, 6, 8, 4 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

//----------------------------------------------
// Задача 1: Генерация одной случайной цифры
// Описание:
// Напиши программу, которая выводит одну случайную цифру от 0 до 9.

// Random rnd = new Random();
// int randomDigit = rnd.Next(0, 9);
// System.Console.WriteLine(randomDigit);

//-----------
// Задача 2: Генерация нескольких случайных цифр
// Описание:
// Напиши программу, которая генерирует и выводит на экран 5 случайных цифр от 0 до 9.

// Random rnd = new Random();
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 9);
//     if (i == 4)
//         System.Console.Write(randomDigit + " ");
//     else
//         System.Console.Write(randomDigit + ", ");
// }

//-----------------------

// Задача 3: Чётные и нечётные цифры
// Описание:
// Напиши программу, которая генерирует 10 случайных цифр от 0 до 9 и выводит их в две категории: 
//чётные и нечётные.

// Подсказка:
// Для проверки чётности числа используй оператор %.

// Random rnd = new Random();
// List<int> evenNumbers = new List<int>();
// List<int> oddNumbers = new List<int>();
// for (int i = 0; i < 10; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     if (randomDigit % 2 == 0)
//     {
//         evenNumbers.Add(randomDigit);
//     }
//     else
//     {
//         oddNumbers.Add(randomDigit);
//     }
// }
// System.Console.WriteLine("Четные: " + string.Join(", ", evenNumbers));
// System.Console.WriteLine("Нечтные: " + string.Join(", ", oddNumbers));

//-----------------
// Задача 4: Максимальная цифра
// Описание:
// Напиши программу, которая генерирует 5 случайных цифр от 0 до 9 и выводит на экран самую большую из них.

// Подсказка:
// Используй переменную, чтобы хранить максимальное число и обновляй её в процессе генерации чисел.

// Random rnd = new Random();
// List<int> randomNumbers = new List<int>();
// int max = 0;
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     randomNumbers.Add(randomDigit);
//     if (randomDigit >= max)
//         max = randomDigit;
// }
// System.Console.Write("Цифры: " + string.Join(", ", randomNumbers));
// System.Console.WriteLine();
// System.Console.Write("Максимальная: " + max);

//------------------------

// Задача 5: Сумма случайных цифр
// Описание:
// Напиши программу, которая генерирует 5 случайных цифр от 0 до 9 и выводит их сумму.

// Random rnd = new Random();
// int sum = 0;
// List<int> randomNumbers = new List<int>();
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     randomNumbers.Add(randomDigit);
//     sum = sum + randomDigit;
// }
// System.Console.Write("Цифры: " + string.Join(", ", randomNumbers));
// System.Console.Write("\nСумма: " + sum);

//---------------------------

// Задача 6: Определение одинаковых цифр
// Описание:
// Напиши программу, которая генерирует 5 случайных цифр от 0 до 9 и проверяет, есть ли среди них одинаковые.
// Random rnd = new Random();
// List<int> digits = new List<int>();
// for (int i = 0; i < 5; i++)
// {
//     int randomDigit = rnd.Next(0, 10);
//     System.Console.Write(randomDigit + " ");
//     digits.Add(randomDigit);
// }
// bool hasDuplicates = digits.GroupBy(x => x).Any(g => g.Count() > 1);
// Console.WriteLine("\nЕсть одинаковые цифры: " + (hasDuplicates ? "Да" : "Нет"));

//----------------------

//int[] numbers = new int[5]; // Массив из 5 челых чисел.
//numbers[0] = 10; // Присваевываем первое значение.
//numbers[1] = 20; // Присваывываем второе значение.
//int[]numbers = {1,2,3,4,5}; // Инициализация массива при создании.

//----------------

// Задача 1: Создание и вывод массива
// Описание:
// Напиши программу, которая создаёт массив из 5 целых чисел и выводит их на экран.

// int[] numbers = { 1, 2, 3, 4, 5 };
// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

//----------------------

// Задача 2: Заполнение массива с клавиатуры
// Описание:
// Напиши программу, которая запрашивает у пользователя 5 чисел и заполняет ими массив, 
// а затем выводит этот массив на экран.


// int[] numbers = new int[5];
// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write("Введите числа: ");
//     numbers[i] = int.Parse(Console.ReadLine()!);
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

//-----------------------

// Задача 3: Сумма элементов массива
// Описание:
// Напиши программу, которая находит сумму всех элементов массива из 5 чисел.

// int[] numbers = { 1, 2, 3, 4, 5 };
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     sum = sum + numbers[i];
// }
// System.Console.WriteLine("Сумма: " + sum);

//-------------------

// Задача 4: Максимальное значение в массиве
// Описание:
// Напиши программу, которая находит максимальное значение в массиве из 5 чисел.

// int[] numbers = { 100, 2, 3, 4, 5 };
// int max = numbers[0];
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }
// System.Console.WriteLine(max);

//---------------------

// Задача 5: Поиск элемента в массиве
// Описание:
// Напиши программу, которая запрашивает у пользователя число и проверяет, содержится ли оно в массиве.

// int[] numners = { 1, 2, 3, 4, 5 };
// System.Console.WriteLine("Введите число для поиска: ");
// int search = int.Parse(Console.ReadLine()!);
// bool found = false;

// for (int i = 0; i < numners.Length; i++)
// {
//     if (numners[i] == search)
//     {
//         found = true;
//         break;
//     }
// }

// if (found)
// {
//     System.Console.WriteLine("Число найдено в массиве.");
// }
// else
// {
//     System.Console.WriteLine("Число не найдено.");
// }

//----------------------------

// Задача 6: Переворот массива (реверс)
// Описание:
// Напиши программу, которая переворачивает массив, то есть меняет порядок его элементов на обратный.

// int[] numbers = { 1, 2, 3, 4, 5 };
// Array.Reverse(numbers);
// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

// Задача 7: Чётные числа в массиве
// Описание:
// Напиши программу, которая выводит все чётные числа из массива.

// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// List<int> evenNumbers = new List<int>();
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         evenNumbers.Add(numbers[i]);
//     }
// }
// System.Console.WriteLine("Четные: " + string.Join(", ", evenNumbers));

//-----------------------

// Задача 8: Сортировка массива
// Описание:
// Напиши программу, которая сортирует массив по возрастанию.

// int[] numbers = { 1, 5, 2, 7, 3, 9, 5, 12 };
// Array.Sort(numbers);
// for (int i = 0; i < numbers.Length; i++)
// {
//     System.Console.Write(numbers[i] + " ");
// }

//-----------------------

// Задача 9: Заполнение массива случайными числами
// Описание:
// Напиши программу, которая заполняет массив из 10 элементов случайными числами от 1 до 100 и выводит его.

// Random rnd = new Random();
// int[] numbers = new int[10];
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = rnd.Next(1, 101);
//     System.Console.Write(numbers[i] + " ");
// }

//-------------------------------

// Задача 10: Минимальное и максимальное значения в массиве
// Описание:
// Напиши программу, которая находит минимальное и максимальное значения в массиве из 10 случайных чисел.

Random rnd = new Random();
int[] numbers = new int[10];
int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, 101);
    if (numbers[i] > max) max = numbers[i];
    if (numbers[i] < min) min = numbers[i];
}

Console.WriteLine("Минимальное значение: " + min);
Console.WriteLine("Максимальное значение: " + max);