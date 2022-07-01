/*Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

void Palidrom ()
{   
    Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
        
    int error = number / 10000; 

    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int num3 = number / 10 % 10;
    int num4 = number % 10;
    
    if (error < 1 || error > 9)
    {
        Console.WriteLine("Не является пятизначным числом");
    }

    else 
        if  (num1 == num4 && num2 == num3)
        {
        Console.WriteLine("Палидром");
        }
        else
        {
        Console.WriteLine("Данное число не является палидромом");
        }
    
}

Palidrom();*/


 

/*Задача 2. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
от 1 до N.

void Cube (int x)
{
    int current = 1;
    while (current <= x)
    {
        int Cube = current * current * current;
        Console.Write(Cube + " ");
        current++;
    }
}
 Console.WriteLine("Input a number: ");
 int num = Convert.ToInt32(Console.ReadLine());
 
 Cube(num); */