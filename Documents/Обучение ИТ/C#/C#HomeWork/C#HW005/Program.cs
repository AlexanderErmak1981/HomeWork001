// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int MassiveNumber(int length)
{
    int[] newArray = new int[length];
    int minValue = 100;
    int maxValue = 999;

    for(int i = 0; i < length; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write($"Array: ");
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = (MassiveNumber(size));

ShowArray(myArray);

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)count++;
    }
    return count;
}

Console.WriteLine($"The number of even numbers in the array {FindEvenNumbers(myArray)}");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] MassiveNumber(int length, int minValue, int maxValue)
{
    int[] newArray = new int[length];

    for(int i = 0; i < length; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write($"Array: ");
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write(array[i]);
    }
    Console.WriteLine();
}

Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Minimum value of the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Maximum value of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = (MassiveNumber(size, min, max));

ShowArray(myArray);

int SumOddPosition(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i +=2)
    {
        sum = array[i] + sum;
    }
    return sum;
}

Console.WriteLine($"The sum of the elements standing in odd positions is equal to: '{SumOddPosition(myArray)}'");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] MassiveNumber(int length, int minValue, int maxValue)
{
    double[] newArray = new double[length];

    for(int i = 0; i < length; i++)
    {
        double number1 = new Random().Next(minValue, maxValue + 1);
        double number2 = Math.Round(new Random().NextDouble(), 1);
        newArray[i] = number1 + number2;
    }
    return newArray;
}

void ShowArray(double[] array)
{
    Console.Write($"Array: ");
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length -1) Console.Write(array[i]);
        else Console.Write(array[i] + "| ");
    }
    Console.WriteLine();
}

Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Minimum value of the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Maximum value of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = (MassiveNumber(size, min, max));

ShowArray(myArray);

double MinMaxDif(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];
    double difference = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNumber) maxNumber = array[i];
        if(array[i] < minNumber) minNumber = array[i];
    }
    difference = maxNumber - minNumber;
    return difference;
}

Console.WriteLine($"The difference between the maximum and minimum element of the array is - '{Math.Round(MinMaxDif(myArray),2)}'");
