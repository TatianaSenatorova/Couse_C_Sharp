﻿/*Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

void EvenNums(int m, int n)
{
    if(n < m) return;
    if(n % 2 == 0)
    {EvenNums(m, n - 2);
    Console.Write($"{n}, ");
    }
    else if (n % 2 == 1)
    {
        n = n - 1;
        EvenNums(m, n);
    }
}
EvenNums(4, 16);
Console.WriteLine();
EvenNums(1, 11);