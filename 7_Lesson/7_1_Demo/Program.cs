

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
   Console.WriteLine();
}

int[,] MassNums(int row,  int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        arr[i, j] = new Random().Next(-10, 100);
          Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    return arr;
}

Console.WriteLine("Enter the number 0f rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number 0f columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 6);
Print(arr_1);