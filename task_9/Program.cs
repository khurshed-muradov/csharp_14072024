// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
int UserInput()
{
    int im_userInput = int.Parse(Console.ReadLine()!);
    return im_userInput;
}
int om_FirstUserInput = UserInput();
int om_SecondUserInput = UserInput();

if (om_FirstUserInput * om_FirstUserInput == om_SecondUserInput || om_SecondUserInput * om_SecondUserInput == om_FirstUserInput)
{
    System.Console.WriteLine(om_FirstUserInput + ", " + om_SecondUserInput + " -> да");
}
else
{
    System.Console.WriteLine(om_FirstUserInput + ", " + om_SecondUserInput + " -> нет");
}