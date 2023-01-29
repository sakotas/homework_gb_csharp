using static System.Console;
Clear();

// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве,
// и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

WriteLine("Введите кол-во строк и столбцов через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"Кол-во строк: {int.Parse(parameters[0])}");
WriteLine($"Кол-во столбцов: {int.Parse(parameters[1])}");

WriteLine("Введите индексы строки и столбца через пробел: ");
string[] valueCoords = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int coordX = int.Parse(valueCoords[0]);
int coordY = int.Parse(valueCoords[1]);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);
ReturnValueBasedOnCoords(array, coordX, coordY);

WriteLine();
WriteLine("====UNIT TEST====");
int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintMatrixArray(testArray);
ReturnValueBasedOnCoords(testArray, coordX, coordY);

void ReturnValueBasedOnCoords(int[,] inArray, int row, int column)
{
    if(row < 0 || column < 0 || row > inArray.GetLength(0) || column > inArray.GetLength(1)) WriteLine($"{row} ; {column} -> такого элемента в массиве нет");
    else WriteLine($"{row} ; {column} -> {inArray[row, column]}");
}

int[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
        }

    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],2} ");
        }
        WriteLine();
    }
}