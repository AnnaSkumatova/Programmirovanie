/*Задача 1. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summa(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Summa of numbers {num} is {Summa(num)}");



Задача 2. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.*/

int[] Array(int size, int min, int max)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max + 1);

    return newArray;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Array(size, min, max);

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

ShowArray(array);


