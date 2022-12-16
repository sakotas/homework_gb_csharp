/* Задача 4: Напишите программу, 
которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

using static System.Console;
Clear();

Write("Enter first number: ");
int num1 = int.Parse(ReadLine()!);
Write("Enter second number: ");
int num2 = int.Parse(ReadLine()!);
Write("Enter third number: ");
int num3 = int.Parse(ReadLine()!);

int max = num1;

if (max < num2) 
{
    max = num2;
}
    if (max < num3) 
    {
        max = num3;
    }

WriteLine($"max = {max}");