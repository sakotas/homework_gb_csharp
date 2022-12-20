// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;
Clear();

WriteLine("Input three-digit number: ");
int num = int.Parse(ReadLine()!);

if(num > 99)
{
    int a = num%1000/100;
    WriteLine(a);
}
else 
{
    WriteLine("третьей цифры нет");
}

// You can use short oneline command
// Uncomment line 25 and comment lines 13-21
// WriteLine(num > 99?num%1000/100:"третьей цифры нет");