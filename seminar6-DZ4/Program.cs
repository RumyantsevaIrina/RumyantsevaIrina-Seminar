// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
string inputString = "Hello World It's a Beautiful Day"; // исходная строка

string[] words = inputString.Split(' '); // разбиваем строку на слова

Array.Reverse(words); // переворачиваем массив слов

string reversedString = String.Join(" ", words); // объединяем слова обратно в строку с пробелами

Console.WriteLine(reversedString);