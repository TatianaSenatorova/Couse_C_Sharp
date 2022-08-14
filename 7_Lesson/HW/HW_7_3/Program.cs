/*Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.*/

/*First variant*/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
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

double[] AverageNumsInColumn(int[,] arr)
{
    double row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double[] arr_average = new double[column];
           
    for (int j = 0; j < column; j++)
    {
        double sum_column = 0;
        for (int i = 0; i < row; i++)
        {
            sum_column += arr[i, j];
        }
        arr_average[j] = Math.Round(sum_column / row, 2); 
        Console.Write ($"An average sum in {j + 1} column → {arr_average[j]}");
        Console.WriteLine();
        sum_column = 0;
    }
return arr_average; 
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
AverageNumsInColumn(arr_1);


/*Second variant*/

/*void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
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

void AverageNumsInColumn(int[,] arr)
{
    double row = arr.GetLength(0);
    int column = arr.GetLength(1);
              
    for (int j = 0; j < column; j++)
    {
        double sum_column = 0;
        for (int i = 0; i < row; i++)
        {
            sum_column += arr[i, j];
        }
        double arr_average = Math.Round(sum_column / row, 2); 
        Console.Write ($"An average sum in {j + 1} column → {arr_average}");
        Console.WriteLine();
        sum_column = 0;
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);
AverageNumsInColumn(arr_1);*/

