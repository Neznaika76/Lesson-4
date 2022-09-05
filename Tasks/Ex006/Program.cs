// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Sum(double[] Arr)
    {
        double max = Arr[0];
        double min = Arr[0];
        for(int i=0; i<Arr.Length; i++)
            {
             if(max<Arr[i])
                 max=Arr[i];
             if(min>Arr[i])
                 min=Arr[i];
            }
            //Console.WriteLine("Максимум " + max);
            //Console.WriteLine("Минимум " + min);
            max=max-min;
        Console.WriteLine("Разность между максимальным и минимальным элементом равна " + max);
    }

Console.Write("Введите размер массива: ");
int x =Convert.ToInt32(Console.ReadLine());
double[] array = new double[x];
Random random=new Random();

for(int i=0; i<array.Length; i++)
    array[i]=random.Next(0,100);

Console.WriteLine("[{0}]",string.Join(",",array));
Sum(array);