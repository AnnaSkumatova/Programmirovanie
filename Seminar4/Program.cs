/*Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <=a; current++)
        sum += current;// sum = sum + current;

    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");*/




/* Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Kolich(int num)
{
    int result = 1;
    int i = 1;
    while (num / i > 10)
    {
        i = i * 10;
        result++;
    }
    return result;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Kolich(n));



int Numbers(int a)
{
    int current = 0;
    if (current <= a)
    {
        while (a > 0)
        {
            a = a / 10;
            current++;
        }
    }
    return current;
}

Console.WriteLine("Введите число: ");
int numko1 = Convert.ToInt32(Console.ReadLine());
int numb = Numbers(numko1);
Console.WriteLine(numb);*/

/*Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Proisv(int N)
{
    int result = 1;
    for(int i = 1; i <= N; i++)
        result = result * i;
    return result;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proisv(n)); */




/*Задача 4. Напишите программу, которая принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.

int Step(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
        result = result * a;
    return result;
}
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Step(n, m));
*/