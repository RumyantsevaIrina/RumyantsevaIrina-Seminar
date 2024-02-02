// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

namespace NumberDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число N:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Цифры числа {0}:", number);

            string digits = GetNumberDigits(number);
            Console.WriteLine(digits);
        }
        static string GetNumberDigits(int number)
        {
            string digitsString = "";

            while (number > 0)
            {
                int digit = number % 10;
                digitsString = digit + "," + digitsString;
                number = number / 10;
            }

            // Удаляем последнюю запятую
            digitsString = digitsString.TrimEnd(',');

            return digitsString;
        }
    }
}