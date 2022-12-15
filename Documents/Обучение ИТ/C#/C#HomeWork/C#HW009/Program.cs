// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
Console.WriteLine();
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumber(int m, int n)
{
    if(n > m)
    {
        return SumNumber(m, n - 1) + n;
    }
    else return m;
}

Console.Write("Input m: ");
var num_m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
var num_n = Convert.ToInt32(Console.ReadLine());

if( num_m > num_n)
{
    int temp = num_m;
    num_m = num_n;
    num_n = temp;
    Console.Write($"The sum of natural elements in the range from {num_n} to {num_m} - {SumNumber(num_m, num_n)}");
}
else
{
    if(num_m == num_n) Console.Write($"Input number 'n' greater than 'm', now they are equal!");
    else Console.Write($"The sum of natural elements in the range from {num_m} to {num_n} - {SumNumber(num_m, num_n)}");
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Input m: ");
var num_m = Convert.ToDouble(Console.ReadLine());

Console.Write("Input n: ");
var num_n = Convert.ToDouble(Console.ReadLine());

double FuncAkkerman(double m, double n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0 && m > 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else
    {
        return (FuncAkkerman(m - 1, FuncAkkerman(m, n - 1)));
    }
}

Console.Write($"{FuncAkkerman(num_m, num_n)}");