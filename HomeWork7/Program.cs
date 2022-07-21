/*Задача. Задайте двумерный массив размером m * n, заполненный случайными вещественными числами.

double[,] CreateRandom2DArray(int rows, int columns) 
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 100) + new Random().NextDouble();

    return newArray;
} 

void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2DArray(m, n);
Show2DArray(myArray); */











/*Задача. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2DArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(0, 51);

    return newArray;
} 

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}


void MeaningElementArray(int[,] array)
{
    Console.Write("Input number rows: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number columns: ");
    int j = Convert.ToInt32(Console.ReadLine()); 

                
    if(i < array.GetLength(0) && j < array.GetLength(1))
        Console.WriteLine(array [i,j]);
    else
        Console.WriteLine("There is no such number in the array");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());



int[,] myArray = CreateRandom2DArray(m, n);
Show2DArray(myArray);
MeaningElementArray(myArray);
*/







/*Задача. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

int[,] CreateRandom2DArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1,100);

    return newArray;
} 

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
}
 

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n);
Show2DArray(myArray);

for (int i = 0; i < n; i++)
    {
        double summ = 0;
        for (int j = 0; j < m; j++)
            {
                summ = summ + myArray[j,i];
            }
            double average = summ / m;
            int a = i + 1;
        Console.WriteLine("Average for " + a +" column is " + average);    
    } 


  