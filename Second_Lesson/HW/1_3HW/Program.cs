/*Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Write a number: ");
int a=int.Parse(Console.ReadLine());
if (a<100) Console.WriteLine("There is no third digit");
else{
while (a>1000){
  a=a/10;
}
Console.WriteLine($"Third digit in number is {a % 10}");
}
