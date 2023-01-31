// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


using static System.Console;
Clear();

WriteLine("====UNIT TESTS====");
int[] testArray = new int[90];  // we have 90 diff 2digit numbers
for (int i = 0; i < 90; i++)
{
    testArray[i] = i + 10;
}

int[,,] array = new int[10, 3, 3];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for(int k=0; k< 3; k++)
        {
            array[i,j,k] = PickRandom(testArray);
            WriteLine($"{array[i,j,k]} ({i},{j},{k})");
        }
    }
}

int PickRandom(int[] inArray)
{
    int result = 0;
    Random rnd = new Random();
    int GoLeft = rnd.Next(0, 2);
    int index = rnd.Next(0, 91); 

    int count = 0;  
    while (count < inArray.Length)
    {
        if (inArray[index % 90] != 0)
        {

            result = inArray[index % 90];
            inArray[index % 90] = 0;
            return result;
        }
        index = (GoLeft == 1)? (index + 1) : (index-1);  
        index = (index ==-1)? 89: index;

        count++;
    }
    return -1;  
}
