// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
char[,] charArray = { { 'H', 'e', 'l', 'l', 'o' }, { 'W', 'o', 'r', 'l', 'd' } };
string result = String.Empty;

for (int i = 0; i < charArray.GetLength(0); i++)
{
    for (int j = 0; j < charArray.GetLength(1); j++)
    {
        result += charArray[i, j];
    }
}

Console.WriteLine(result);