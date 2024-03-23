// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        
        Array.Reverse(array);
        
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}