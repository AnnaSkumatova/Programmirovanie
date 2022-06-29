/* Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3 


int a, b;

Console.Write("Input first number: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("First number more: " + a );
    Console.WriteLine("Second number less: " + b);
}
else
{
    Console.WriteLine("First number less: " + a );
    Console.WriteLine("Second number more: " + b);
} */




/* Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


int num1, num2, num3, nummax;

Console.Write("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

nummax = num1;

if(nummax < num2)
{
    nummax = num2;
}

if(nummax < num3)
{
    nummax = num3;
}

Console.WriteLine("Max number: " + nummax); */




/* Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4->да
- 3->нет
7->нет 


int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if(num%2 == 0)
{
    Console.WriteLine("Данное число является четным");
}
else
{
    Console.WriteLine("Введенное число нечетное.");
} */




/* Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8}
} */


int N, a;

Console.Write("Input a number: ");
N = Convert.ToInt32(Console.ReadLine());

a = 2;

while (a <= N)
{
    Console.Write( a + " ");
    a = a + 2; 
}

















