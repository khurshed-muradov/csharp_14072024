// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
int digitN = int.Parse(Console.ReadLine());
int digitNnegative = digitN - digitN * 2;
int i = digitNnegative;
while (i <= digitN)
{

    System.Console.WriteLine(i);
    i = i + 1;
}
