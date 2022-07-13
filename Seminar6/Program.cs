/*Задача. Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--) // i < j
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    // int i = 0, j = array.Length - 1;

    // while(i < j)
    // {
    //     int temp = array[i];
    //     array[i] = array[j];
    //     array[j] = temp;

    //     i++;
    //     j--;
    // }

    return array;
}

int[] myArray = {3, 5, 1, 8, 2, 9, 4};
myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
    Console.Write(myArray[i] + " ");
*/


//Задача. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 18 / 2 -> 9 0
// 9 / 2 -> 4 1
// 4 / 2 -> 2 0
// 2 / 2 -> 1 0
// 1 / 2 -> 0 1 снизу вверх записываем остатки. 18 -> 10010


/*string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;

    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2; //то же самое, что и num = num / 2
    }

    return resultNumber;
}

Console.WriteLine(ChangeDigitSystem(18));*/





/* Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
 треугольник с сторонами такой длины.
 a < b + c



void Triangle (int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int c = Convert.ToInt32(Console.ReadLine());

Triangle(a, b, c);*/




/*
bool Triangle (int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}
// Console.Write("Input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Triangle(a, b, c));

bool isTriangle = false;
isTriangle = Triangle(1,2,3);

Console.WriteLine(isTriangle);*/




bool Triangle (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
bool isTriangle = false;
isTriangle = Triangle(1,2,3);

Console.WriteLine(isTriangle);





//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//0 1 1 2 3 5 8 13 21 34 55
/*
int[] Fibonacci(int n)
{
    int[] newArray = new int[n];
    Console.WriteLine("Creating array here: ");
   
    newArray[0] = 0;
    newArray[1] = 1;
    
    for(int i = 2; i < n; i++)
    {
        newArray[i] = newArray[i - 1] + newArray [i - 2];
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(num));
*/