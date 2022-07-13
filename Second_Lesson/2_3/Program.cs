/*Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление.*/

void Multiple (int first, int second){
    if (first%
    second==0) 
         Console.WriteLine("Кратно"); 
    else Console.WriteLine($"Некратно. Остаток {first%second}");
}

Console.WriteLine("Write a first number: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Write a second number: ");
int b=int.Parse(Console.ReadLine());
Multiple(a, b);