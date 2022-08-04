/*Напишите программу, которая задаёт массив из
8 элементов случайными числами и выводит их на экран.
Оформите заполнение массива и вывод в виде функции
(пригодится в следующих задачах)
1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1
*/

int [] EightMass(int N)
{
    int[] arr=new int[N];
    for(int i=0; i<N; i++)
    {
        arr[i]=new Random().Next(0, 100);
    }
    return arr;
   }
void PrintArray(int [] array)
{
    int count=array.Length;
    for (int i=0; i<count; i++)
    Console.Write($"{array[i]}, ");
}
Console.WriteLine(EightMass(8));
PrintArray(EightMass(8));