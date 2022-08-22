/*Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNums(int m, int n)
{
    if( n < m) return 0;
    return SumNums(m, n-1) + n;
}
Console.Write(SumNums(1, 15));
Console.WriteLine();
Console.Write(SumNums(4, 8));