/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*First version*/
void Palindrome(int a)
{
    int b=a/1000;
    int c=a/10;
    if(a/10000==a%10 && b%10==c%10)
        Console.WriteLine($"{a} Yes, it`s a palindrome");
    else  Console.WriteLine($"{a} No, it`s not a palindrome");
}
Palindrome(14212);
Palindrome(12821);
Palindrome(23432);

/*Second version*/

/*void Palindrome(string a)
{
    if(a.Substring(0, 1)==a.Substring(4, 1) && a.Substring(1, 1)==a.Substring(3, 1))
    Console.WriteLine($"{a} Yes, it`s a palindrome");
    else  Console.WriteLine($"{a} No, it`s not a palindrome");
}
Palindrome("14212");
Palindrome("12821");
Palindrome("23432");*/