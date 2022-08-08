/*Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3, 7, 22, 2, 78] -> 76
*/

void Print(double[] arr)
{
    for (int i=0; i<arr.Length; i++)
    Console.Write ("{0,2:F2} ", + (arr[i]));
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i<size; i++)
    arr[i] = new Random().NextDouble()*100;
    return arr;
}

double SubtractionMaxMin(double[] arr)
{
    double sub_max_min = 0;
    double min = arr [0];
    double max = arr [0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min)
        min = arr[i];
        if(arr[i] > max)
        max = arr[i];
    }
    sub_max_min = max - min;
    return sub_max_min;
}


double[] arr_1 = MassNums(5);
Print(arr_1);
Console.WriteLine($"Difference between max number and  min number in mass→ " + "{0,2:F2} ", + (SubtractionMaxMin(arr_1)));

double[] arr_2 = MassNums(6);
Print(arr_2);
Console.WriteLine($"Difference between max number and  min number in mass→ "+ "{0,2:F2} ",  + (SubtractionMaxMin(arr_2)));
