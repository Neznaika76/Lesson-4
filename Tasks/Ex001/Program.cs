// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int degree (int A, int B)
    {
        int Rez = A;
        if(B==0)
            return 1;
        else
            for(int i=1; i<B; i++)
                Rez = A*Rez;
        return Rez;
    }

Console.Write("Введите число А - ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В - ");
int numB = Convert.ToInt32(Console.ReadLine());
if(numB>=0)
    Console.WriteLine(degree(numA,numB));
else Console.WriteLine("Введите число В больше нуля");