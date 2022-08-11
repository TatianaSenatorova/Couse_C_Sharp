/*Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{   
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);        
    }    
    return arr;
}

void IfInNum(int[] arr, int num)
{   
    string text = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            text = "Yes";
            break;
        }
    }
    Console.WriteLine($"The num value {num} -> {text}");    
}

int[] arr_1 = MassNums(12, -9, 10);
Print(arr_1);
IfInNum(arr_1, 5);
int[] arr_2 = MassNums(12, -9, 10);
Print(arr_2);
IfInNum(arr_2, 6);
