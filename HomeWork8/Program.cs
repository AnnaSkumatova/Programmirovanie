/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.


int[,] CreateRandom2DArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(10, 31);

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

int[,] Sortirovka (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for (int z = 0; z < array.GetLength(1) - 1; z++)
                if (array[i, z] < array[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                    {
                        int temp = 0;
                        temp = array[i, z];
                        array[i, z] = array[i, z + 1];
                        array[i, z + 1] = temp;
                    }
    return array;
}
Console.WriteLine();


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n);

Show2DArray(myArray);

Console.WriteLine();

Show2DArray(Sortirovka(myArray));
*/






/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка

int[,] CreateRandom2DArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(0, 10);
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

int StringMinSumma (int[,] array)
{
    int min = 0;
    int index = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                {
                sum += array[i, j];
                }
            if (i == 0) min = sum; 
//Павел, признаюсь честно, "слизала" это условие с семинара, "билась" над задачей три дня, решила перевести фокус
на семинар, и тут решение моей проблемы.
            
            if (sum < min)
                {
                    min = sum;
                    index = i;
                }
        }
    return index;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n);

Show2DArray(myArray);

int rezult = StringMinSumma(myArray) + 1;
Console.WriteLine("String with minimum summa: " + rezult);
*/



/*
Задача. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

int[,] Create2DArray(int rows, int columns) 
{
    
    int[,] newArray = new int[rows, columns];
    
    return newArray;
} 

int[,] Spiral (int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;

        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
                i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
                j--;
        else i--;
        
        temp++;
    }
    return array;
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

int m = 4;
int n = 4;

int[,] myArray = Create2DArray(m, n);
myArray = Spiral(myArray);
Show2DArray(myArray);