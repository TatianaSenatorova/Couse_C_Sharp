/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*First version*/
void Palindrome(int a)
{
    string b=a.ToString();
    int N=b.Length;
    int i=0;
    while (i<N/2)
        {
            if(b.Substring(i, 1)==b.Substring(N-1-i, 1))
            {
                i++;
                if (i==(N-1)/2)  
                {Console.WriteLine($"{a} Yes, it`s a palindrome");}
            }
            else  
            {
                Console.WriteLine($"{a} No, it`s not a palindrome");
                break;
            }
         }
            
}
Console.WriteLine("Write any number: ");
int a=int.Parse(Console.ReadLine());
Palindrome(a);

/*Second version*/
/*void Palindrome(int a)
{
    string b=a.ToString();
    if(b.Substring(0, 1)==b.Substring(4, 1) && b.Substring(1, 1)==b.Substring(3, 1))
    Console.WriteLine($"{b} Yes, it`s a palindrome");
    else  Console.WriteLine($"{b} No, it`s not a palindrome");
}
Palindrome(14212);
Palindrome(12821);
Palindrome(23432);*/

/*Third version*/

/*void Palindrome(int a)
{
    int b=a/1000;
    int c=a/10;
    if(a/10000==a%10 && b%10==c%10)
        Console.WriteLine($"{a} Yes, it`s a palindrome");
    else  Console.WriteLine($"{a} No, it`s not a palindrome");
}
Palindrome(14212);
Palindrome(12821);
Palindrome(23432);*/

