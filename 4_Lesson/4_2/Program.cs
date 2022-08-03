/*Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int multiply(int N)
{
    int num=1;
    for (int i=2; i<=N; i++)
    num*=i;
    return num;
}
Console.WriteLine(multiply(4));
Console.WriteLine(multiply(5));