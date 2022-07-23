/*Задача. Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
N = 4532 -> 4*/





/*Задача. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());


int SumOfDigits(int m, int n)
{
    if (m == n)
        return n + SumOfDigits(m, n - 1);
    return n;
}
Console.Write(SumOfDigits(m, n));