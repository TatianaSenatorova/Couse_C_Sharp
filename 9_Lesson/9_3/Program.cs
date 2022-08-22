/*Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9*/

int SumNums(int n)
{
    int sum = 0;
    if(n == 0) return 0;
    return SumNums(n / 10) + n % 10;
}
Console.Write(SumNums(423));