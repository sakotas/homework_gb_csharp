using static System.Console;
Clear();

// Задача 29: Напишите программу, реализующую метод, 
// который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

GetAndPrintArray();

void GetAndPrintArray()
{
    PrintArray(GetArray(8));
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0,100);
    }

    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}