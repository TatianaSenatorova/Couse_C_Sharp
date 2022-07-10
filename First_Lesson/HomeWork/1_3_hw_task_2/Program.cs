/*Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.*/

Console.WriteLine("Write a first number a: ");
Console.WriteLine("Write a second number b: ");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
if(a>b){
    Console.WriteLine(a);
}
else{
    Console.WriteLine(b);
}


