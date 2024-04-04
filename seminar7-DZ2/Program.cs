// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
using System;

class AckermannFunction
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 3; // значение m
        int n = 2; // значение n
        int result = Ackermann(m, n);
        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно {result}.");
    }
}