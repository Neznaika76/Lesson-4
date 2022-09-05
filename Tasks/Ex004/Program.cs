// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void Chet(int[] Arr)
    {
        int num = 0;
        for(int i=0; i<Arr.Length; i++)
            if(Arr[i]%2==0)
                num++;
        Console.WriteLine("Количество четных чисел -> "+num);
    }

int[]array = new int[4];
Random random = new Random();

for(int i=0; i<array.Length; i++)
    array[i]=random.Next(100,999);

Console.WriteLine("[{0}]",string.Join(",",array));
Chet(array);