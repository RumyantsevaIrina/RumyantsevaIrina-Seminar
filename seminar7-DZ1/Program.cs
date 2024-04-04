// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

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