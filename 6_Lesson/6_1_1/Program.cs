/*Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/

void Triangle( int a, int b, int c)
{
    if (c < a + b && a < b + c && b < a + c)
    Console.Write("Yes, it can be a triangle");
    else   Console.Write("No, it can't be a triangle");
}

Triangle(5, 4, 3);