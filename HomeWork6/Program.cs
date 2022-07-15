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
*/

Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
double y = 0;

if(k1 != k2)
{
    x = (b2 - b1)/(k1 - k2);
    Console.WriteLine("Axis intersection point X: " + x);

    y = k1 * ((b2-b1)/(k1-k2))+b1;
    Console.WriteLine("Axis intersection point Y: " + y);
}

else
    Console.WriteLine("No Point Intersections");




