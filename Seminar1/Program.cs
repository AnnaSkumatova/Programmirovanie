/* Задача 1. Необходимо запросить у пользователя два целых числа (int). Определить является ли первое число 
квадратом второго числа?

int num1, num2, quad;

Console.Write("Input a first number:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)
{
    Console.WriteLine("First number is a quad of second number");
}
else
{
    Console.WriteLine("First number is not a quad of second number");
}
*/

/* Задача 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

int day;

Console.Write("Введите порядковый номер дня недели: ");
day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
{
    Console.Write("Понедельник");
}
if(day == 2)
{
    Console.Write("Вторник");
}
if(day == 3)
{
    Console.Write("Среда");
}
if(day == 4)
{
    Console.Write("Четверг");
}
if(day == 5)
{
    Console.Write("Пятница");
}
if(day == 6)
{
    Console.Write("Суббота");
}
if(day == 7)
{
    Console.Write("Воскресенье");
}
if(day > 7 || day < 1)
{
    Console.Write("Ошибка. Введите число от 1 до 7.");
}*/



/* Задача 3. Напишите программу, которая на вход принимает число и выдаёт его квадрат.

int num, quad;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

quad = num * num;

Console.Write("Квадрат числа " + num + " равен " + quad);
*/


/* Задача 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает 
все целые числа в промежутке от -N до N.

int n, current;

Console.Write("Input a number: ");
n = Convert.ToInt32(Console.ReadLine());

current = n * (-1);

while (current <= n)
{
    Console.Write(current + " ");
    current++; //current = current + 1
} */
