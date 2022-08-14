/*Задайте двумерный массив. Найдите элементы, у которых
обе позиции чётные, и замените эти элементы на их квадраты.

Например, изначально массив   
вот так:
выглядел вот так:                   
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
1 4 7 2
5 81 2 9
8 4 2 4  */

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
   Console.WriteLine();
}

int[,] MassNums(int row,  int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        arr[i, j] = new Random().Next(from, to);
    }
    return arr;
}

int[,] NewArray(int[,] arr)
{
int row_size = arr.GetLength(0);
int column_size = arr.GetLength(1);

  for (int i = 1; i < row_size; i += 2)
    {
        for (int j = 1; j < column_size; j += 2) 
        {
                arr[i, j] *= arr[i, j];
        }
    }
    return arr;
}
Console.WriteLine("Enter the number 0f rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number 0f columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
NewArray(arr_1);
Print(arr_1);