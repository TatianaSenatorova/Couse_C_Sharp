/*Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. В массиве вещественные числа*/

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]} ");
}

double[] MassNums(int N)
{
    double[] arr = new double[N];
    Random n_new = new Random();
    for (int i = 0; i < N; i++)
    {
        arr [i] = Math.Round(n_new.NextDouble() * (41 + 10) - 24, 2);
    }
    return arr;
}

double[] NewMassNumsCopy(double[] arr)
{
    double[] new_arr_copy = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        new_arr_copy [i] = arr [i];
    }
    return new_arr_copy;
}

double[] arr_1 = MassNums(5);
Print(arr_1);
NewMassNumsCopy(arr_1);
Console.WriteLine();
Console.WriteLine($"Copy new mass → ");
Print(NewMassNumsCopy(arr_1));