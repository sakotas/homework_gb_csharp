// Задача 68: Напишите программу реализующую метод вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

WriteLine(Akkerman(2,3));
WriteLine(Akkerman(3,2));
// WriteLine(Akkerman(4,4));

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1); 
    else return Akkerman(m - 1,Akkerman(m, n- 1));
}