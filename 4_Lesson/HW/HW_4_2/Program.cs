/*Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*First variant mathematical*/

/*int SumNum(int A)
{
    int result=0;
    while (A>0)
    {
    result=result+A%10;
    A/=10;
    }
    return result;
}
Console.WriteLine(SumNum(452));
Console.WriteLine(SumNum(82));
Console.WriteLine(SumNum(9012));*/

/*Second variant array*/

int SumNum(int A)
{
   int [] array=new int [A];
   int Sum=0;
   for (int i=0; A>0; i++)
   {
       array[i]=A%10;
       A/=10;
       Sum=Sum+array[i];
   }
return Sum;
}
Console.WriteLine(SumNum(452));
Console.WriteLine(SumNum(82));
Console.WriteLine(SumNum(9012));