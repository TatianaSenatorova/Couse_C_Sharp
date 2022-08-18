/*Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. Значения элементов массива 0..9
Набор данных                            Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }              0 встречается 2 раза
                                        1 встречается 1 раз
                                        2 встречается 1 раз
                                        8 встречается 1 раз
                                        9 встречается 3 раза*/

void NumsRepeatHowOften(int[] arr)
    {                            
        Dictionary<int, int> HowOften = new Dictionary<int, int>();
        foreach(int n in arr)
        {            
            if(HowOften.ContainsKey(n))
                HowOften[n]++;
            else 
                HowOften[n] = 1;
        }
            
        foreach(KeyValuePair<int, int> pair in HowOften)
            Console.WriteLine("{0} ->встречается {1}", pair.Key, pair.Value);
    }
int[] arr = {1, 9, 9, 0, 2, 8, 0, 9}; 
NumsRepeatHowOften(arr);