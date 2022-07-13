﻿//Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int EvenNum (int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count = count + 1;
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 99;
int max = 998;

int[] array = CreateRandomArray(size, min, max);

ShowArray(array);
int result = EvenNum(array);
Console.WriteLine("The number of even numbers in the array: " + result); */



//Задача 2. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SummaElementov (int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1) sum += array[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int result = SummaElementov(array);
Console.WriteLine("Summa elementov: " + result);





 /*Задача 3. Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементами массива.*/
/*
 double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size]; 

    for(int i = 0; i < size; i++)
    {   
        newArray[i] =new Random().Next(1, 100) + new Random().NextDouble();
    }

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double min(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    return min;
}


double max(double[]array)
{
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
       if (array[i] > max) max = array [i];
    return max;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(size);

ShowArray(array);

double Difference = max(array) - min(array); 
Console.WriteLine("Difference MaxMin: " + Difference);*/







