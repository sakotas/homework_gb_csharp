// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;
Clear ();

Write("input x1:");
if (!int.TryParse(ReadLine(), out int X1))
{
    WriteLine("Error. Input number, not string");
    return;
}

Write("input y1:");
if (!int.TryParse(ReadLine(), out int Y1))
{
    WriteLine("Error. Input number, not string");
    return;
}

Write("input z1:");
if (!int.TryParse(ReadLine(), out int Z1))
{
    WriteLine("Error. Input number, not string");
    return;
}

Write("input x2:");
if (!int.TryParse(ReadLine(), out int X2))
{
    WriteLine("Error. Input number, not string");
    return;
}

Write("input y2:");
if (!int.TryParse(ReadLine(), out int Y2))
{
    WriteLine("Error. Input number, not string");
    return;
}

Write("input z2:");
if (!int.TryParse(ReadLine(), out int Z2))
{
    WriteLine("Error. Input number, not string");
    return;
}

double distance = Math.Sqrt (Math.Pow((X2 - X1),2) +  Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2));
WriteLine ("Distanse between 2 points in 3-d dimension is {0:f2}", distance);