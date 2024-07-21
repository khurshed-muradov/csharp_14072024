// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int UserInput()
{
    int im_userInput = int.Parse(Console.ReadLine()!);
    return im_userInput;
}

int om_userInput = UserInput();

if (om_userInput % 7 == 0 && om_userInput % 23 == 0)
{
    System.Console.WriteLine(om_userInput + " -> да");
}
else
{
    System.Console.WriteLine(om_userInput + " -> нет");
}



