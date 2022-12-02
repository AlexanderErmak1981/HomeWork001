// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int CountNumbers()
{
    Console.WriteLine("how many numbers will you enter: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"Input {i + 1} number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) sum++;
    }
    return sum;
}

Console.WriteLine($"The number of numbers greater than '0': {CountNumbers()}");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindIntersectionPoint()
{
    Console.Write("Input b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    if((k1 == k2) && (b1 == b2)) Console.WriteLine("Straight lines match!");
    else
    {
        if (k1==k2) Console.WriteLine("Straight parallel!");
        else Console.WriteLine($"Two straight lines will intersect at a point with coordinates X: {x}, Y: {y}");
    }
}

FindIntersectionPoint();