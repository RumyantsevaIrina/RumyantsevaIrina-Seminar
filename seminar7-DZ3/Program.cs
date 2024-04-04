// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

using System;

public class Program

{

    static Random random = new Random();

    static void FillArrayRecursively(int[] array, int index)

    {

        if (index < array.Length)

        {

            array[index] = random.Next(100);

            Console.Write(array[index] + " ");

            FillArrayRecursively(array, index + 1);

        }

    }

    static void ReversePrint(int[] arr, int index)

    {

        if (index >= 0)

        {

            Console.Write(arr[index] + " ");

            ReversePrint(arr, index - 1);

        }

    }
    static void Main()

    {

        Console.Write("Введите размер массива: ");

        int size = int.Parse(Console.ReadLine());

        int[] myArray = new int[size];

        Console.WriteLine("Сгенерированный массив: ");

        FillArrayRecursively(myArray, 0);

        Console.WriteLine("Перевернутый массив: ");

        ReversePrint(myArray, myArray.Length - 1);
    }

}