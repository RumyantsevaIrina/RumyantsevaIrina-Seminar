// void F(int a)
// {
//     if (a >= 1)
//     {
//         F(a - 1);
//         System.Console.Write(a + " ");
//     }
// }

// // F(5);

// int SumOfDigits(int a)//456 -> 15, 45
// {
// if(a > 0)
// {
// return SumOfDigits(a/10) + a%10;
// }
// return 0;
// }

// System.Console.WriteLine(SumOfDigits(456));


// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
void F(int m, int n)
{
    if (m != n)
    {
        if (m > n)
        {
            F(m - 1, n);
            System.Console.Write(m + " ");
        }
        else
        {

            F(m + 1, n);
            System.Console.Write(m + " ");

        }

    }
    else
    {
        System.Console.Write(m + " ");
    }
}

F(m, n);