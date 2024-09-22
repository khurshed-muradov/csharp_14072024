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

