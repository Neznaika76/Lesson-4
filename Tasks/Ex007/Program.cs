// Задача 39: Задайте массив вещественных чисел. 
// Поменяйте местами элементы массива.
// [3 7 22 2 78] -> 76

void Sum(double[] Arr)
    {
        double Per = Arr[0];
        for(int i=0, j =Arr.Length-1; i<Arr.Length/2; i++,j--)
            {
                Per = Arr[i];
                Arr[i]=Arr[j];
                Arr[j]=Per;
            }
            //Console.WriteLine("Максимум " + max);
            //Console.WriteLine("Минимум " + min);
            //Console.WriteLine("Разность между максимальным и минимальным элементом равна " + max);
    }

Console.Write("Введите размер массива: ");
int x =Convert.ToInt32(Console.ReadLine());

double[] array = new double[x];
Random random=new Random();

for(int i=0; i<array.Length; i++)
    array[i]=random.Next(0,100);

Console.WriteLine("[{0}]",string.Join(",",array));
Sum(array);
Console.WriteLine("[{0}]",string.Join(",",array));