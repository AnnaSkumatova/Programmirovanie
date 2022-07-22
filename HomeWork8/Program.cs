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
1 строка*/

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
    int sum = 0;
    int index = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        {
            int temp = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                {
                sum += array[i, j];
                }
                if (sum > temp)
                    {
                        sum = temp;
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

Console.WriteLine("String with minimum summa: " + StringMinSumma(myArray));
// int SummaString (int[,] array)
// {
//     int sum = 0;

//     for (int i = 0; i < n; i++)
//         for (int j = 0; j < m; j++)
//             sum = sum + array[i,j];
//     return sum;
// }

// int minsum = 0;
// int sumstring = SummaString(myArray);
// for(int i = 1; i < myArray.GetLength(0); i++)
//         {
//             int temp = SummaString(myArray);
//             int min = i;
            
//             if(sumstring > temp)
//             {            
//                 sumstring = temp;
//                 minsum = i;
//             }

//         }
// Console.WriteLine( minsum + 1 + "- строкa с наименьшей суммой.");
// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
// int tempSumLine = SumLineElements(array, i);
// if (sumLine > tempSumLine)
// {
// sumLine = tempSumLine;
// minSumLine = i;
// }
// }
// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
// int SumLineElements(int[,] array, int i)
// {
// int sumLine = array[i,0];
// for (int j = 1; j < array.GetLength(1); j++)
// {
// sumLine += array[i,j];
// }
// return sumLine;
//     int minSumma = ;
//     int sumLine = SumLineElements(array, 0);
//     for (i = 1; i < array.GetLength(0); i++)
//     {
  
//   if (sumLine > int tempSumLine)
//     {
//         tempSumLine = SumLineElements(array, i);
//         sumLine = tempSumLine;
//         minSum = i;
//     }



// for (int i = 0; i < n; i++)
//     {
//         double summ = 0;
//         for (int j = 0; j < m; j++)
//             {
//                 summ = summ + myArray[j,i];
//             }
//             double average = summ / m;
//             int a = i + 1;
//         Console.WriteLine("Average for " + a +" column is " + average);    
//     } 





// for (int i = 0; i < n; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < m; j++)
//                 sum = sum + myArray[i, j];        
            
//             if (sum < minsum)
//                 {
//                     minsum = sum;
//                     indexLine++;
//                 }
        
//     }
// Console.WriteLine("Cтрока с наименьшей суммой элементов: " + (indexLine));

// int minsum = 0;
// int indexLine = 0;

// for (int i = 0; i < n; i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < m; j++)
//             {
//                 summ = summ + myArray[i,j];
//             }
//             if (summ < minsum)
//                 minsum = summ;
//                 int a = i + 1;
            
            
//     Console.WriteLine("Cтрока с наименьшей суммой элементов: " + indexLine);
//     }   



/*
Задача. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/