// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

int GetPointArea(int cordX, int cordY)
{
    int numberArea = 0;
    if (cordX > 0 && cordY > 0)
    {
        numberArea = 1;
    }
    if (cordX < 0 && cordY > 0)
    {
        numberArea = 2;
    }
    if (cordX < 0 && cordY < 0)
    {
        numberArea = 3;
    }
    if (cordX > 0 && cordY < 0)
    {
        numberArea = 4;
    }
return numberArea;
}

Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);

Console.WriteLine(numberArea);