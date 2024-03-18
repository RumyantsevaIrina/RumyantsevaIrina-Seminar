// Задание 1. Совместная работа
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int[] array = { 1, 3, 4, 19, 3 };
int number = 5;
bool result = false;
for (int i = 0; i < array.Length; i++)
{
if (array[i] == number)
{
result = true;
break;
}
}
if (result == true)
{
System.Console.WriteLine("YES");
}
else
{
System.Console.WriteLine("No");
}
// int[] SingInvert(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = array[i] * -1;
// }
// return array;
// }

// System.Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(size, min, max);
// PrintArray(arr);
// PrintArray(SingInvert(arr));