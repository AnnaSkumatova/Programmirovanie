/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 



int CutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    return result;
}

int number = CutNumber();
Console.WriteLine("Result number is " + number);



void CutNumberVoid()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Current random number is " + num);

    int sotni = num / 100;
    int ed = num % 10;

    int result = sotni * 10 + ed;
    Console.WriteLine("Result number is " + result);
}

CutNumberVoid();*/



/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает 
наибольшую цифру числа.*/

int MaxNumber()
{
    int num = new Random().Next(10, 100);
    Console.Write(num);

    int firstnum = num % 10;
    int secondnum = num / 10;

    if (firstnum > secondnum)
    {
        return firstnum;
    }
    else
    {
        return secondnum;
    }
       
}

int res = MaxNumber;
console.Write(res);




/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void CutNumberVoid()
{
    int num;

    Console.Write("Input a number: ");
    num = Convert.ToInt32(Console.ReadLine());
    
    if(num % 7 == 0)
    {   
        if(num % 23 == 0)
        {
        Console.WriteLine("Число является кратным 7 и 23");
        }
        else
        {
        Console.WriteLine("Число не является кратным 7 и 23");
        }
    }
    else
    {
        Console.WriteLine("Число не является кратным 7 и 23");
    }
};

CutNumberVoid(); */




/* Напишите программу, которая принимает на вход два числа и проверяет, является ли 
одно число квадратом другого.

void IsQuad ()
{
    int num1;
    int num2;

    Console.Write("Input a first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    int quad2 = num2 * num2;
    int quad1 = num1 * num1;

    if(num1 == quad2)
        Console.WriteLine("Yes");
    else
        if(num2 == quad1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
}

IsQuad(); */


