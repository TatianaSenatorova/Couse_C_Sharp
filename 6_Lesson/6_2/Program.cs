/*Задача 2: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

string TransformDecimBinary(int Num)
{
 string result = "";
 while(Num > 0)
 {
   result = Num % 2 + result;
   Num /=2;
 }
return result;
}
Console.WriteLine($"{45} →{TransformDecimBinary(45)}");
