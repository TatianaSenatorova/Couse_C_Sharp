/*Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.*/

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

int[,] MassNumsSecond(int row_second, int column_second, int from, int to)
{
    int[,] arr = new int[row_second, column_second];

    for (int i = 0; i < row_second; i++)
    {
        for (int j = 0; j < column_second; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void MatrixMultiplication(int [, ] arr1, int [, ] arr2)
{
    int row_size_1 = arr1.GetLength(0);
    int column_size_1 = arr1.GetLength(1);
    int row_size_2 = arr2.GetLength(0);
    int column_size_2 = arr2.GetLength(1);
    int[,] arr = new int[row_size_1, column_size_1];

    if(row_size_1 != row_size_2 || column_size_1  != column_size_2 )
    {
        Console.WriteLine($"It's impossible ");
    }
    else
    {
        for (int i = 0; i < row_size_1; i++)
        {
            for (int j = 0; j < column_size_1; j++)
            {
                arr[i, j] = arr1[i, j] * arr2[i, j];
                Console.Write($"{arr[i, j], 6} ");
            }
           Console.WriteLine(); 
        }
        Console.WriteLine();
    }
   
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Enter the number of rows: ");

Console.Write("Enter the number of rows of second mass: ");
int row_second = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns of second mass: ");
int column_second = int.Parse(Console.ReadLine());


int[,] arr_1 = MassNums(row, column, -5, 10);
Print(arr_1);

int[,] arr_2 = MassNumsSecond(row_second, column_second, -7, 12);
Print(arr_2);

MatrixMultiplication(arr_1, arr_2);




