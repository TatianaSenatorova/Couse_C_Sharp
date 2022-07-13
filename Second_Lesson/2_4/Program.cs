/*Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и
23.*/

void Multiple (int num){
    if (num%7==0 && num%23==0) 
         Console.WriteLine("Кратно"); 
    else Console.WriteLine("Некратно");
}

Console.WriteLine("Write a number: ");
int a=int.Parse(Console.ReadLine());
Multiple(a);