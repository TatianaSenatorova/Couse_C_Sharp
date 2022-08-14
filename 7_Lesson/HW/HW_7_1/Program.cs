/*Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*First variant*/
void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
                {
                    Console.Write($"{arr[i, j], 10}");
                }
        }
         Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
                arr[i, j] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
        }
    }
  return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[, ] arr_1 = MassNums(row, column);
Print(arr_1);


/*Second variant*/

/*void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
             {
                {
                    Console.Write($"{arr[i, j], 10}");
                }
             }
         Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] MassNums(int row, int column)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
                arr[i, j] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 1);
        }
    }
  return arr;
}

double[, ] arr_1 = MassNums(3, 4);
Print(arr_1);*/