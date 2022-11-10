// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom(long number)
{
    long TempNumber = number;
    long ReverseNumber = 0;
    if(number < 10 && number > -10)
    {
        Console.Write($"Введите число более двух знаков ");
    }
    else
    {
        if(number > 0)
        {
            while(number > 0)
            {
                long remainder = number % 10;
                ReverseNumber = ReverseNumber * 10 + remainder;
                number = number / 10;
            }
            if(TempNumber == ReverseNumber) Console.Write($"Число {TempNumber} является палиндромом и в обратном порядке будет {TempNumber}");
            else Console.Write($"Число {TempNumber} не является палиндромом, так как в обратном порядке будет {ReverseNumber}");
        }
    }
}

Console.Write("Введите число: ");
long num1 = Convert.ToInt64(Console.ReadLine());
Palindrom(num1);
*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
void DistanceXYZ(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 -y1) + (z2 - z1) * (z2 - z1));
    Console.Write($"Расстояние между точками в 3D пространстве: {distance}");
} 

Console.Write("Введите первое число координаты Х: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число координаты Х: ");
double Xb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первое число координаты Y: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число координаты Y: ");
double Yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первое число координаты Z: ");
double Za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число координаты Z: ");
double Zb = Convert.ToDouble(Console.ReadLine());

DistanceXYZ(Xa, Xb, Ya, Yb, Za, Zb);
*/
 
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int number)
{
    int i = 1;
    if(number > 0)
    {
        while(i <= number)
        {
            if(i == number) Console.Write($"{i * i * i}");
            else Console.Write($"{i * i * i}, ");
            i ++;
        }
    }
    else
    {
        Console.Write($"Вы ввели \"{number}\", данное число меньше или равно \"0\", введите число больше \"0\"");
    }
}
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Cube(num1);