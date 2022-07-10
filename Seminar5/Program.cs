/*//Генерирует массив из целочисленных элементов, которые заданы случайным образом.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; //инициализирует массив newArray

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

//Генерирует массив из целочисленных элементов, которые заданы пользователем.

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

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
int[] array2 = CreateArray(size);

ShowArray(array1);
ShowArray(array2);*/


/* Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму положительных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; //инициализирует массив newArray

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

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];

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
int sumOfPositive= FindPositiveSum(array);
Console.WriteLine("Sum of positive elements in current array is " + sumOfPositive);*/


/*Задача. Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

int[] Array2(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    newArray[i] = newArray[i] * - 1;

    return newArray;
}

void ShowArray(int[] array)
{
 for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int[] NewArray = Array2(array);
ShowArray(NewArray);
*/



/*Задача. Задайте одномерный массив из 20 случайных чисел. Найдите количество 
элементов массива, значения которые лежат в отрезке [10,99].*/

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

int FindTwoDigits(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] >=10 && array[i] <= 99) count++;

    return count;
}

int size = 20;
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count of two-digit elements is " + FindTwoDigits(array));