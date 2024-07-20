// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int GetRandomNumber()
{
    int randomNumber = new Random().Next(100, 1000);
    return randomNumber;
}

int GetFirstDigit(int firstDigit)
{
    firstDigit = firstDigit / 100;
    return firstDigit;
}

int GetThirdDigit(int thirdDigit)
{
    thirdDigit = thirdDigit % 10;
    return thirdDigit;
}

void PrintNumber(int print1)
{
    Console.Write(print1 + " -> ");
}

int outRandomNumber = GetRandomNumber();
PrintNumber(outRandomNumber);
int outGetFirstDigit = GetFirstDigit(outRandomNumber);
//PrintNumber(outGetFirstDigit);
int outGetThirdDigit = GetThirdDigit(outRandomNumber);
//PrintNumber(outGetThirdDigit);
System.Console.Write($"{outGetFirstDigit}{outGetThirdDigit}");
