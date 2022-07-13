/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Write a number of the week day: ");
int a=int.Parse(Console.ReadLine());
if (a<=0 || a>7) Console.WriteLine("You had mistaked. Please, try again");
else if(a==6 || a==7) Console.WriteLine("Yes! Hurray, it is weekend!"); 
else Console.WriteLine("No. It is weekday."); 