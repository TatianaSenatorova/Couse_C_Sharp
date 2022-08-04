/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*First variant with cycle*/

int Exponent(int A, int B)
{
    int result=1;
    for (int i=1; i<=B; i++)
    result=result*A;
    return result;
  }
Console.WriteLine(Exponent(3, 5));
Console.WriteLine(Exponent(2, 4));

/*Second variant without cycle*/

/*void Exponent(int A, int B)
{
    Console.WriteLine($"{A} в степени {B} →  {Math.Pow(A,B)}");
  }
Exponent(3, 5);
Exponent(2, 4);*/

