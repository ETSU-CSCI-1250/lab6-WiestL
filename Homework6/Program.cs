// See https://aka.ms/new-console-template for more information

using System;

ShowCharacter("food", 4);

static void ShowCharacter(string a, int b)
{
    Console.WriteLine($"The {b} character of {a} is {a[b-1]}.");
}


CalculateRetail(50, 25);

static void CalculateRetail(double a, double b)
{
    Console.WriteLine($"The retail price is {a + (a * (b/100))}");
}

for(int i = 80; i >= 80 && i <= 100; i++)
{
    Console.WriteLine($"{i} in celcius is {Celsius(i)}");
}

static double Celsius(double a)
{
    double mult = (5.0 / 9.0);
    double cels = mult*(a - 32);
    return cels;
}

static void IsPrime(int a)
{
    int count = 0;
    for (int i = 2; i < a / 2; i++)
    {
        if (a % i == 0)
        {
            count = 1;
            break;
        }
    }
    if (count == 1)
    {
        Console.WriteLine("False");
    }
    else
    {
        Console.WriteLine("True");
    }
}

IsPrime(7);


