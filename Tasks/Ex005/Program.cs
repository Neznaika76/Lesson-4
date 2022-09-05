// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Sum(int[] Arr)
    {
        int S =0;
        for(int i=1; i<Arr.Length; i=i+2)
            S=S+Arr[i];
        Console.WriteLine("Сумма элементов на начетных позициях равна " + S);
    }

Console.Write("Введите размер массива: ");
int x =Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
Random random=new Random();

for(int i=0; i<array.Length; i++)
    array[i]=random.Next(-100,100);

Console.WriteLine("[{0}]",string.Join(",",array));
Sum(array);