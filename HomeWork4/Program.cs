﻿/*Задача 1. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

int[] Array(int m)
{
    int size = new Random().Next(1, 101);
    int[]array = new int[size];

    for(int i = 0; i < size; i++);
    return array;
}

Console.Write("Input number: ");
int m = Convert.ToInt32(Console.ReadLine());

m = array(m);

Console.WriteLine($"Array {Array(m)}");

