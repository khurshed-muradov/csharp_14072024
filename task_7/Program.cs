// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int UserInput()
{
    int in_userInput = int.Parse(Console.ReadLine()!);
    return in_userInput;
}

int out_userInput1 = UserInput();
int out_userInput2 = UserInput();
//int divide = out_userInput2 % out_userInput1;
//int divide2 = out_userInput2 % out_userInput1;
if (out_userInput1 % out_userInput2 == 0)
{
    //System.Console.WriteLine($"{out_userInput1}, {out_userInput2} -> кратно");
    System.Console.WriteLine($"{out_userInput1}, {out_userInput2} -> кратно");
}
else
{
    System.Console.WriteLine($"{out_userInput1}, {out_userInput2} -> не кратно, остаток {out_userInput1 / out_userInput2}");
}

