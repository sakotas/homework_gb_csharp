// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using static System.Console;
Clear();

WriteLine("Input one-digit number from 1 to 7: ");
int num = int.Parse(ReadLine()!);

if (num < 1 || num > 7)
{
    WriteLine($"You entered wrong number {num} is out of range from 1 to 7");
}
else if (num == 6 || num == 7)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}

// You can use short oneline command
// Uncomment line 29 and comment lines 13-25
// WriteLine((num < 1) || (num > 7)?$"You entered wrong number {num} is out of range from 1 to 7":(num == 6) || (num == 7)?"Да":"Нет");