/*Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Write a first number a;");
Console.WriteLine("Write a second number b;");
Console.WriteLine("Write a third number c;");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());
int max=a;
if(b>max){
    max=b;
}
if(c>max){
    max=c;
}
Console.WriteLine(max);


