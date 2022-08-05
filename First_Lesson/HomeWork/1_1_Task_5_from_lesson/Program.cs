/*Мария, добрый день, данную задачу сделала и для отрицательных чисел. 
Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.*/

Console.WriteLine("Write a number a; ");
int a=int.Parse(Console.ReadLine());
int i=-a;
   while(i!=a){
    if (i<a){
        Console.WriteLine(i);
        i++;
    }
    else{
        Console.WriteLine(-a);
        a++;
    }
   }
    if (i<a){
        Console.WriteLine(a);
    } 
    else {
        Console.WriteLine(i);  
    }