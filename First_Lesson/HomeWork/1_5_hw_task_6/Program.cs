﻿/*Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).*/

Console.WriteLine("Write a number a:");
int a=int.Parse(Console.ReadLine());
if (a%2==0){
    Console.WriteLine("Четное число");
}
else {
  Console.WriteLine("Нечетное число");  
}

