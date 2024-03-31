// // Задайте массив символов (тип char []). Создайте строку из
// // символов этого массива.
// // Указание
// // Конструктор строки вида string(char []) не использовать.

// string CharsArrToString(char[] chars)
// {
// string result = "";
// for (int i = 0; i < chars.Length; i++)
// {
// result = result + chars[i];
// }
// return result;
// }

// char[] InputCharArr(int n)
// {
// char[] chars = new char[n];
// for (int i = 0; i < chars.Length; i++)
// {
// System.Console.Write($"input character number {i+1} : ");
// chars[i] = Convert.ToChar(Console.ReadLine());
// }
// return chars;
// }

// char[] chars = InputCharArr(12);
// string res = CharsArrToString(chars);
// System.Console.WriteLine(res);

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// // Метод строки ToCharArray() не использовать

// char[] MyToCharArray(string str)
// {
// char[] chars = new char[str.Length];
// for (int i = 0; i < chars.Length; i++)
// {
// chars[i] = str[i];
// }

// return chars;
// }

// void PrintArray(char[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// System.Console.Write(array[i] + " ");
// }
// System.Console.WriteLine();
// }

// System.Console.Write("Input any string: ");
// string str = Console.ReadLine();
// PrintArray(MyToCharArray(str));

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountCharString(string str)
{
    char[] chars = {'a', 'e', 'y', 'u', 'i', 'o'};
    int count = 0;
    for (int i = 0; i < chars.Length; i++)
    {
        foreach (char item in str)
        {
            if (item == chars[i])
            {
                count++;
            }
        }
    }
    return count;
}

Console.WriteLine("Inpute strng: ");
string str = Console.ReadLine();
Console.WriteLine(CountCharString(str));