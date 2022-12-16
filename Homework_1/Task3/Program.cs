/* Задача 6: Напишите программу, 
которая на вход принимает число и выдаёт, 
является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

using static System.Console;
Clear();

Write("Enter number: ");
int num = int.Parse(ReadLine()!);

int even = num % 2;

if (even == 0) {
    WriteLine($"Yes, number {num} is even");
}
else 
{
    WriteLine($"No, number {num} is odd");
}
