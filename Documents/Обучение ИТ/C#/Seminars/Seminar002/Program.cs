/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec; 

    return max;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);
Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");
*/

int MakeNewDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int newNumber = sot * 10 + ed;

    return newNumber;
}

int randNumber = new Random().Next(100, 1000);
int newDigit = MakeNewDigit(randNumber);
Console.WriteLine($"RandomNumber is {randNumber} New digit is {newDigit}");