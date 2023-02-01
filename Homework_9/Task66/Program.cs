// Задача 66: Напишите программу, которая реализует 
// рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();


WriteLine(GetNumbers(15, 1));
WriteLine();
WriteLine(GetNumbers(8, 4));
WriteLine();

int GetNumbers(int n, int m)
{
    if (n < m) return (n < m)? GetNumbers(n, m - 1) + m: m;
    else return (m < n)? GetNumbers(n - 1, m) + n: n;
}