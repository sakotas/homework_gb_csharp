// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;
Clear();

WriteLine("Input three-digit number: ");
int num = int.Parse(ReadLine()!);

if(num > 99 && num < 1000)
{
    int a = num%100/10;
    WriteLine(a);
}
else 
{
    WriteLine($"Please enter 3-digit number. Number {num} doesn't meet this requirement");
}

// You can use short oneline command
// Uncomment line 25 and comment lines 13-21
// WriteLine((num > 99) && (num < 1000)?num%100/10:$"Please enter 3-digit number. Number {num} doesn't meet this requirement");

// You can use randomizer to generate random numbers that meets algorythm requirements
// Uncomment lines 29-32 and comment lines 10-21
// int number = new Random().Next(100,1000);
// WriteLine(number);
// int a = number%100/10;
// WriteLine(a);
