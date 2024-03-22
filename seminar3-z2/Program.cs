// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]

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

int [] CreateNewArray (int [] array)
{
int [] array2 = new int [array.Length/2];
for (int i = 0; i < array.Length/2; i++)
{
array2[i] = array[i]*array[array.Length-1-i];
}
return array2;
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
PrintArray(CreateNewArray(arr));
int[] Multiply(int[] array)
{
int[] new_array = new int[array.Length / 2];
for (int i = 0; i < array.Length / 2; i++)
{
new_array[i] = array[i] * array[array.Length - 1 - i];
}
return new_array;
}
