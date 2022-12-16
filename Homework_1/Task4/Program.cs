/* Задача 8: Напишите программу,
которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

using static System.Console;
Clear();

Write("Enter number: ");
int num = int.Parse(ReadLine()!);

int count = 1;
while (count <= num)
{
if (count % 2 == 0)
    if (count == num)
    {
        Write(count);
    }
    else if (count == num - 1)
    {
        Write(count);
    }
    else {
        Write($"{count}, ");
    }
    count++;
}