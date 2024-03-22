// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3
int[] CreateArray(int n, int min, int max)
{
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1);
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
}

int SimpleNumbersCount(int[] arr)
{
int countNum = 0;
foreach (int item in arr)
{
int count = 0;
for (int i = 2; i <= item; i++)
{
if(item % i == 0)
{
count++;
}
}
if(count == 1)
{
countNum++;
}
}
return countNum;
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine(SimpleNumbersCount(arr));