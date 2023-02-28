//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4-> 16
Console.WriteLine("input two numbers: A and B");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 1;
while (count< b)
{
    result = result * a;
    count++;
    
}
Console.WriteLine(result);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("input some number and you will get the sum of its digits ");

int SumOfNumbers(int n)
{
    int len = Convert.ToString(n).Length;
    int digits = 0;
    int result = 0;

    for (int i = 0; i < len; i++)
    {
        digits = n - n % 10;
        result = result + (n - digits);
        n = n / 10;
    }
    return result;
}
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfNumbers(num));

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33-> [6, 1, 33]
