/*Задача. Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от 1 до N.

void ShowNums(int n)
{
    if(n > 1)
    {
        //Console.Write(n + " ");
        ShowNums(n - 1);
    }
    
    Console.Write(n + " ");
}
ShowNums(5);



Задача. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.


int SumOfDigits(int n)
{
    if(n >= 10)
    {
        return n % 10 + SumOfDigits(n / 10);
    }
    else return n;
}

Console.WriteLine();
Console.WriteLine(SumOfDigits(12345));



Задача. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N.

void ShowNums(int m, int n)
{
    if(n > m)
    {
        ShowNums(m, n - 1);
    }
    
    Console.Write(n + " ");
}
ShowNums(1,10);*/





/*Задача. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B 
с помощью рекурсии.*/


int Vozvod (int a, int b)
{
    if(b > 1)
    {
        return a * Vozvod (a, b-1);
    }
    else return a;
}

Console.WriteLine(Vozvod(3,2));
