/*Задача. Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
N = 4532 -> 4*/

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int CountOfDigits(int n) 
{
    if(n < 10)
        return 1;
    else return CountOfDigits(n / 10) + 1;
}

Console.WriteLine(CountOfDigits(n));





/*Задача. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());


int SumOfDigits(int m, int n)
{
    if (m == n)
        return n;
    return n + SumOfDigits(m, n - 1);
    
}
Console.Write(SumOfDigits(m, n));*/