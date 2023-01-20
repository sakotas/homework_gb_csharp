using static System.Console;
Clear();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

WriteLine("========НАЧАЛО========");
Write("Введите число b1: ");
checkParsing(double.TryParse(ReadLine()!, out double b1));
Write("Введите число k1: ");
checkParsing(double.TryParse(ReadLine()!, out double k1));
Write("Введите число b2: ");
checkParsing(double.TryParse(ReadLine()!, out double b2));
Write("Введите число k2: ");
checkParsing(double.TryParse(ReadLine()!, out double k2));

WriteLine();
WriteLine("======================");
PrintCoordinates(FormArrayFromInput(b1, k1, b2, k2));

WriteLine();
WriteLine("=======UNIT TESTS=======");

//                      b1 k1 b2 k2
double[] testArray1 = { 2, 5, 4, 9 };
PrintCoordinates(testArray1);
WriteLine();
WriteLine("========КОНЕЦ========");
WriteLine();

void PrintCoordinates(double[] inArray)
{
    if ((inArray[0] == inArray[2]) && (inArray[1] == inArray[3])) WriteLine("Прямые совпадают");
    else if (inArray[1] == inArray[3]) WriteLine("Прямые паралелльные");
    else
{
    PrintValues(inArray);
    Write(" -> ");
    double[] coords = FindCoordinates(inArray);
    WriteLine($"({coords[0]}; {coords[1]})");

}

}

double[] FindCoordinates(double[] inArray)
{
    double[] coordinates = new double[2];
    double b1 = inArray[0];
    double k1 = inArray[1];
    double b2 = inArray[2];
    double k2 = inArray[3];
    if ((k1 == k2) && (b1 == b2)) WriteLine("Прямые совпадают");
    else if (k1 == k2) WriteLine("Прямые паралелльные");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        coordinates[0] = x;
        coordinates[1] = y;
    }
    return coordinates;
}

double[] FormArrayFromInput(double b1, double k1, double b2, double k2)
{
    double[] resultArray = new double[4];
    resultArray[0] = b1;
    resultArray[1] = k1;
    resultArray[2] = b2;
    resultArray[3] = k2;
    return resultArray;
}

void PrintValues(double[] inArray)
{
    Write($"b1 = {inArray[0]}, ");
    Write($"k1 = {inArray[1]}, ");
    Write($"b2 = {inArray[2]}, ");
    Write($"k2 = {inArray[3]} ");
}

void checkParsing(bool isParse)
{
    if (!isParse)
    {
        Console.WriteLine($"Проверка не пройдена - НЕ ЧИСЛО!");
    }
    else
    {
        Console.WriteLine($"Проверка пройдена");
    }
}