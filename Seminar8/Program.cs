/*Задача. Задайте двумерный массив. Напишите программу, которая заменяет строки
на столбцы. В случае, если это невозможно, программа должна вывести
сообщение для пользователя.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue) 
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

int[,] Reverse2DArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Number of rows and columns is not the same!");
        return array;
    }

    for(int i = 0; i < array.GetLength(0) - 1; i++)
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
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

int[,] myArray = CreateRandom2DArray(m, n, min, max);

Show2DArray(myArray);
Console.WriteLine();
Show2DArray(Reverse2DArray(myArray));






Задача. Из двумерного массива целых чисел удалить строку и столбец, на
пересечении которых расположен наименьший элемент.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue) 
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

int[,] Cut2DArray(int[,] array)
{
    int iMin = 0;
    int jMin = 0;

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[iMin,jMin])
            {
                iMin = i;
                jMin= j;
            }
        }

    for(int j = 0; j < array.GetLength(1); j++)
        array[iMin, j] = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        array[i, jMin] = 0;

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

int[,] myArray = CreateRandom2DArray(m, n, min, max);

Show2DArray(myArray);
Console.WriteLine();
Show2DArray(Cut2DArray(myArray));*/





/*Задача. Задайте двумерный массив. Напишите программу, которая поменяет местами
первую и последнюю строку массива*/

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

int [,] ChangeString (int [,] array)
{
    for(int j = 0; j < array.GetLength(0); j++)
        {
            int temp = array[0,j];
            array[0,j] = array[array.GetLength(0) - 1,j];
            array[array.GetLength(0) - 1,j] = temp; 

        }
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

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
Console.WriteLine();
Show2DArray(ChangeString(myArray));





