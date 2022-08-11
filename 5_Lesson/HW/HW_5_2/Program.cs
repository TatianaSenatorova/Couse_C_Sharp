/*Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67] -> 0
*/

void Print(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    Console.Write ($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i<size; i++)
    arr[i] = new Random().Next(-100, 1000);
    return arr;
}

int SumEvenPos(int[] arr)
{
    int sum_even_pos=0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 0)
        {
            sum_even_pos = sum_even_pos + arr[i];
        }
    }
    return sum_even_pos;
}

int[] arr_1 = MassNums(5);
Print(arr_1);
Console.WriteLine($"Sum numbers on even positions → " + (SumEvenPos(arr_1)));

int[] arr_2 = MassNums(6);
Print(arr_2);
Console.WriteLine($"Sum numbers on even positions → " + (SumEvenPos(arr_2)));
