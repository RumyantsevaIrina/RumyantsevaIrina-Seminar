// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

string inputString = "А роза упала на лапу Азора"; // произвольная строка

// Удаляем из строки все пробелы и приводим к нижнему регистру
string cleanString = String.Join("", inputString.ToLower().Where(Char.IsLetter));

// Создаем строку-палиндром путем обращения исходной строки
string reversedString = new string(cleanString.Reverse().ToArray());

bool isPalindrome = cleanString == reversedString;

if (isPalindrome)
{
    Console.WriteLine("Данная строка является палиндромом.");
}
else
{
    Console.WriteLine("Данная строка не является палиндромом.");
}