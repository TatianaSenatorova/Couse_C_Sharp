/*Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 
*/

/*First variant*/
/*void Num(int A)
{
    string number=A.ToString();
    Console.WriteLine(number.Length);
}
Num(123);*/

/*Second variant*/

int NumCount(int num)
{
    int result=0;
    while (num>0)
    {
        num/=10;
        result+=1;
    }
    return result;
}
Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));