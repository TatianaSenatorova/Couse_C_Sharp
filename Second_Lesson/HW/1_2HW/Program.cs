/*Напишите программу, которая выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/

/*First version*/
int a=new Random().Next(100, 1000);
Console.WriteLine($"Three-digit random number {a}");
Console.WriteLine($"This number without second digit {a/100}{a%10}");

/*Second version*/
/*int a=new Random().Next(100, 1000);
string str = a.ToString();
Console.WriteLine($"Three-digit random number {str}");
str=str.Remove(1,1);
Console.WriteLine($"This number without second digit {str}");*/

