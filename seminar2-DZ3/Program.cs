// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.WriteLine("Введите целое число от 10 до 99:");
            int number = int.Parse(Console.ReadLine());

            int maxDigit = 0;
            int tempDigit;

            while (number > 0)
            {
                tempDigit = number % 10;
                if (tempDigit > maxDigit)
                {
                    maxDigit = tempDigit;
                }
                number = number / 10;
            }

            Console.WriteLine("Наибольшая цифра в числе: " + maxDigit);