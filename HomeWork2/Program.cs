/* Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

int SecondNum()
{
    int num;

    Console.Write("Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());

    int des = num / 10 % 10;
    int result = des ;

    return result;
}
 int number = SecondNum();
 Console.WriteLine("Result is " + number);*/




/*Задача 2. Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.*/


void ThirdNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());



    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    
    if (99 < number && number > 1000)
    {
        int num1 = number%10;
        Console.WriteLine("Третья цифра " + num1);
    }
    
    if (number > 999)
    {
        int num2 = 0;

        while(num2 < 1000)
        {
            num2 = number/100;
        };

        int result = number % 10;
        Console.WriteLine("Третья цифра " + result);
            
    }


}
ThirdNumber();



/*

void ThirdNumber()
{   
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int num1 = number / 100;
    int num2 = num1;


    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }

    else 
        if  (99 < num1 && num1 > 1000)
        {
        Console.WriteLine("Третья цифра " + num1);
        }
        else 
            while(num1 < 999)
            {
            Console.WriteLine("Третья цифра " + num2);
            num2 = num1 / 100;
        


            }
    
}

ThirdNumber();*/



/* Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

void DayOff()
{
    int day;

    Console.Write("Введите порядковый номер дня недели: ");
    day = Convert.ToInt32(Console.ReadLine());

    if(day == 1)
    {
        Console.Write("Понедельник - будний день");
    }
    if(day == 2)
    {
        Console.Write("Вторник - будний день ");
    }
    if(day == 3)
    {
        Console.Write("Среда - будний день");
    }
    if(day == 4)
    {
        Console.Write("Четверг - будний день");
    }
    if(day == 5)
    {
        Console.Write("Пятница - будний день");
    }
    if(day == 6)
    {
        Console.Write("Суббота - выходной день");
    }
    if(day == 7)
    {
        Console.Write("Воскресенье - выходной день");
    }
    if(day > 7 || day < 1)
    {
        Console.Write("Ошибка. Введите число от 1 до 7.");
    }
};

DayOff();*/