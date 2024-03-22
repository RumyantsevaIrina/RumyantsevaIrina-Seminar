// Задача 2: Задайте массив заполненный 
// случайными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
class Program
{
    static void Main()
    {
        int[] array = new int[10]; // Создаем массив из 10 элементов
        Random random = new Random();

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        int countEven = 0;

        // Подсчитываем количество четных чисел в массиве
        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                countEven++;
            }
        }

        Console.WriteLine("Массив случайных трехзначных чисел:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nКоличество четных чисел в массиве: " + countEven);
    }
}