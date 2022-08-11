/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

/*First variant*/

int PositiveNums(int M)
{
    int count = 0;
    for (int i = 1; i <= M; i++)
    {
    Console.WriteLine($"Input {i} number: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 0) count++;
    }
    return count;
}

Console.WriteLine($"Please, write, how many numbers do you want to input: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine($"Positive numbers: {PositiveNums(M)}");

/*second variant*/

/*int PositiveNums()
{
    int count = 0;
    string num = " ";
    int i = 1;

    while (num != "")
    {
        Console.WriteLine($"Input {i} number or if you don't want to input press button enter: ");
        num = Console.ReadLine();
        if (num == "") break;
        else
        {
            int N = Convert.ToInt32(num);
            i++;
            if (N > 0) count++;
        }
    }
    return count;
}

Console.WriteLine($"Positive numbers → + {(PositiveNums())}");*/


