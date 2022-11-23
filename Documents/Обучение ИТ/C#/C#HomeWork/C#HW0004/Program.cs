// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponent()
{
    int result = 0;
    int current = 1;
    Console.Write("Input number A: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number B: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 <= 0 ^ num2 <= 0)
    {
        Console.WriteLine("Incorrect input, numbers less than zero");
    }
    for(int i = 1; i <= num2; i++)
    {
        current = (num1 * current);
        result = current * num1;
    }
    return result;
}

void ExponentShow(int num)
{
    if(num > 0)
    {
        Console.WriteLine($"The result of exponentiation is {num}");
    }
}
ExponentShow(Exponent());

*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumNumber()
{
    int result = 0;
    Console.Write("Input number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; number != i; number /= 10)
    {
        result = result + number % 10;
    }
    if(result < 0)
    {
        result *= (-1);
    }
    return result;
}
Console.WriteLine($"The sum of the numbers is {SumNumber()}");

void SumNumberShow(int num)
{
    Console.WriteLine($"The sum of the digits in the number is equal to {num}");
}

SumNumberShow(SumNumber());

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] ArrayNumber()
{
    Console.Write($"How many numbers will be in the array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] newarray = new int[length];
    int index = 1;
    Console.WriteLine($"You need to enter {length} numbers");

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Input number {index}: ");
        newarray[i] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    return newarray;
}

void ShowArray(int[] array)
{
    Console.Write($"The result is an array of {array.Length} numbers: ");
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
ShowArray(ArrayNumber());
