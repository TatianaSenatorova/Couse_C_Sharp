/*Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; -0,5)
*/

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double y = (b2 * k1 - b1 * k2 ) / (k1 - k2);
    double x = (y - b1)  / k1;
    Console.WriteLine($" The coordinates of intersection point of two lines given by the equations y = k1 * x + b1 and y = k2 * x + b2 is ({x}, {y})");
}

Console.WriteLine($"Please, write number b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine($"Please, write number k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine($"Please, write number b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine($"Please, write number k2: ");
double k2 = double.Parse(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);