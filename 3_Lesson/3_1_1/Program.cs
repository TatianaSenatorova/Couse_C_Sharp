﻿/*Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y)*/

void Coodinates(int a)
{
    if(a==1)
        Console.WriteLine("x>0 and y>0");
    else if(a==2)
        Console.WriteLine("x<0 and y>0");
    else if(a==3)
        Console.WriteLine("x<0 and y<0");
    else if(a==4)
        Console.WriteLine("x>0 and y<0");
        else Console.WriteLine("You are wrong");
}
Coodinates(1);
Coodinates(2);
Coodinates(3);
Coodinates(4);
Coodinates(10);