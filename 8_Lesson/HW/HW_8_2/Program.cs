/*Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.*/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j], 6}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

int[ ] FindSumInRows(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int[] arr_sums = new int[row];

    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            sum += arr[i, j];
        }
        arr_sums[i] = sum;
    }

    return arr_sums;
}

void PrintMinInRow(int[] arr)
{
    int array_size = arr.Length;

    for (int i = 0; i < array_size; i++)
    {
         Console.WriteLine($"Sum numbers in {i+1} row → {arr[i]} ");
    }
}

void RowMinSum(int[] arr)
{
    int min = arr [0];
    int min_index = 0;
    for ( int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            min_index = i;
        }
    }
    Console.WriteLine($"Row with min sum {min_index + 1}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, -5, 10);
Print(arr_1);

FindSumInRows(arr_1);

PrintMinInRow(FindSumInRows(arr_1));

RowMinSum(FindSumInRows(arr_1));