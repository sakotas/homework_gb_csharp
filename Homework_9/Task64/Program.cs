// Задача 64: Напишите программу, которая реализует 
// рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

string result = GetNumbers1(5);
WriteLine(result);
WriteLine();
PrintNumbers(8);

string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{num}, {GetNumbers(num - 1)}";
}

string GetNumbers1(int num)
{
    return num == 1 ? num.ToString() : $"{num}, {GetNumbers1(num - 1)}";
}

void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        Write($"{num}, ");
        PrintNumbers(num - 1);
        
    }
}