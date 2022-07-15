/*Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и
выдаёт номер четверти плоскости, в которой находится
эта точка.*/

void Quaters(int x, int y)
{
if (x==0 || y==0)
     Console.WriteLine("x=0 or y=0");
else if (x>0 && y>0)
    Console.WriteLine("First quater");
else if (x<0 && y>0)
    Console.WriteLine("Second quater");
else if (x<0 && y<0)
    Console.WriteLine("Third quater");
else if (x>0 && y<0)
Console.WriteLine("Fourth quater");
}
Console.WriteLine("Write x: ");
Console.WriteLine("Write y: ");
Quaters(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));