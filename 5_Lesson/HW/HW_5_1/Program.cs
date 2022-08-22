/*Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
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
    arr[i] = new Random().Next(100, 1000);
    return arr;
}

int EvenNums(int[] arr)
{
    int even_nums=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
           even_nums++; 
        }
    }
    return even_nums;
}


int[] arr_1 = MassNums(5);
Print(arr_1);
Console.WriteLine($"Even numbers in mass → " + (EvenNums(arr_1)));

int[] arr_2 = MassNums(10);
Print(arr_2);
Console.WriteLine($"Even numbers in mass → " + (EvenNums(arr_2)));

