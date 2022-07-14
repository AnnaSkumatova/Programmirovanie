/*Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here:");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int PositiveValue (int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0) count ++;

    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());



int[] array = CreateArray(size);

ShowArray(array);

int count = PositiveValue(array);
Console.WriteLine("Number of numbers greater than 0: " + count);*/


/*Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


y = 5 * x + 2
y = 3 * x + 4

x = 3    1   2
y = 17   7   12

y = 13   7   10 

int x;
int y;
int b1;
int b2;
int k1;
int k2;

x = (b2 - b1)/(k1 - k2);*/


