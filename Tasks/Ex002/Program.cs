// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(string number)
    {
        int S = 0;
        int[] numbers = number.ToString().Select(c=>(int)char.GetNumericValue(c)).ToArray();
        for(int i = 0; i<number.Length; i++)
            S=S+numbers[i]; 
            
        return S;
    }

Console.WriteLine("Введите число - ");
int num=Convert.ToInt32(Console.ReadLine());
if(num<0)
    num=num*(-1);
string Text=Convert.ToString(num);
Console.WriteLine(Sum(Text));
