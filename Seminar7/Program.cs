//Задача. Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue) //rows - строка, columns - столбец
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

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
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);*/



/*Задача. Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue) //rows - строка, columns - столбец
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

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

int FindDiagSum(int[,] array)
{
    int sum = 0;

    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0); i++)
            sum +=array[i,i];

    return sum;
    
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);

Console.WriteLine("Sum of main diagonal is " + FindDiagSum(myArray));*/






/*Задача. Задайте двумерный массив размера m на n, каждый элемент в массиве 
находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] Create2dArray(int rows, int columns) 
{ 
    int[,] newArray = new int[rows, columns]; 
        for(int i = 0; i < rows; i++) 
            for(int j= 0; j < columns; j++) 
                newArray[i,j] = i + j; 

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

int[,] myArray = Create2dArray(m,n); 
Show2DArray(myArray); 


*/


/*
Задача. Задайте двумерный массив. Найдите элементы, у которых оба индекса 
чётные, и замените эти элементы на их квадраты.*/

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue) //rows - строка, columns - столбец
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);

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

int[,] Quart (int[,] array) 
{ 
    for(int i = 0; i < array.GetLength(0); i++) 
        for(int j= 1; j < array.GetLength(1); j++) 
            if(i % 2 == 0 && j % 2 == 0) array[i,j] = array[i,j] * array[i,j]; 

    return array; 
} 
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m,n,min,max); 
Show2DArray(myArray); 
Console.WriteLine(); 

myArray = Quart(myArray); 
Show2DArray(myArray);
