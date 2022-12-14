// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] RandomArray2dFloat()
{
    Console.Write("Array size m: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Array size n: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Minimum value of the array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Maximum value of the array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

        double[,] newArray = new double[rows, columns];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                int int_number = new Random().Next(minValue, maxValue + 1);
                double double_number = new Random().NextDouble();
                newArray[i, j] = Math.Round((int_number + double_number),2);
            }
        }
        return newArray;
}

void Show2Darray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|" + array[i, j] + "|");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = RandomArray2dFloat();
Show2Darray(newArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] RandomArray2d()
{
    Console.Write("Array size m: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Array size n: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Minimum value of the array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Maximum value of the array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine()); 

    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns;j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2Darray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +  " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindValueXY(int[,] array)
{
    Console.Write("Input a point X: ");
    int X_point = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a point Y: ");
    int Y_point = Convert.ToInt32(Console.ReadLine());

    if (X_point > array.GetLength(0) || Y_point > array.GetLength(1))
        Console.WriteLine($"The value of the element with coordinates X - '{X_point}' and Y - '{Y_point}' does not exist");
    else Console.WriteLine($"The value of the element with coordinates 'X' - {X_point} and 'Y' - {Y_point} - '{array[X_point, Y_point]}'");
}

int[,] newArray = RandomArray2d();
Show2Darray(newArray);
FindValueXY(newArray);