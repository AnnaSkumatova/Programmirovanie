﻿/* Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
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

void ThirdNumber(int num)
{

if (num > 99)
    while(num <= 1000)
    {    
        int number = num / 100;
        int result = number % 10;

        Console.WriteLine("Третья цифра " + result);
    }
else 
    Console.WriteLine("Третьей цифры нет");
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

ThirdNumber(num1);







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