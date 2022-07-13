/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

/*First version*/
Console.WriteLine("Write a three-digit number: ");
int a=int.Parse(Console.ReadLine());
if (a<100 || a>999) Console.WriteLine("You had written a wrong number (not a three-digit)");
else Console.WriteLine($"The second digit: {(a/10)%10}"); 

/*Second version*/
/*void SecondDigit(int Number){
        Double b=Number/100;
        if(1<=b && b<10)
            Console.WriteLine($"The second digit: {(Number/10)%10}"); 
        else
            Console.WriteLine("You had written a wrong number (not a three-digit)");
   }
Console.WriteLine("Write a three-digit number: ");
int a=int.Parse(Console.ReadLine());
SecondDigit(a);*/

/*Third version*/
/*Console.WriteLine("Write a three-digit number: ");
string a=(Console.ReadLine());
Console.WriteLine(a.Substring(1, 1));*/



