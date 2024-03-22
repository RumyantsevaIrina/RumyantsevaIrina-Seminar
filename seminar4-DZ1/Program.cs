// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.
class Program
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Введите целое число или 'q' для выхода:");
            string input = Console.ReadLine();

            if (input == "q")
            {
                exit = true;
            }
            else
            {
                int number;
                if (int.TryParse(input, out number))
                {
                    if (IsEvenDigitSum(number))
                    {
                        exit = true;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Повторите попытку.");
                }
            }
        }
    }

    static bool IsEvenDigitSum(int number)
    {
        int digitSum = 0;

        foreach (char digitChar in number.ToString())
        {
            if (char.IsDigit(digitChar))
            {
                digitSum += int.Parse(digitChar.ToString());
            }
        }

        return digitSum % 2 == 0;
    }
}