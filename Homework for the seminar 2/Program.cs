/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5, 782 -> 8, 918 -> 1
*/

/*
int ThreeDigitNumber(int number)
{
    int num1 = number / 10; //вычислил десятки
    int num2 = num1 % 10; //вычислил вторую цифру числа
    return Math.Abs(num2); //взял модуль полученной второй цифры, чтобы она в ответе не оказалась отрицательной
}

Console.Write("Input your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int result;

if ((user_number > 99 && user_number < 1000) || (user_number < -99 && user_number > -1000)) //проверка числа на трехзначность, в том числе отрцательных чисел
{
    result = ThreeDigitNumber(user_number);
    Console.WriteLine($"The second digit of your number is {result}");
}
else
{
    Console.WriteLine("Error, your numder is not 3-digit!");
}
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5, 78 -> третьей цифры нет, 32679 -> 6
*/

/*
int Number(int number)
{
    int num1 = number;
    while ((num1 > 1000) || (num1 < -1000))
    {                                         //делим наше число (в том числе отрицательные числа) на 10 до тех пор, пока оно не станет трехзначным
        num1 = num1 / 10;     //опытным путем установил, что введенное число должно быть меньше 2200000000 
    }                          //(иначе Unhandled exception. System.OverflowException: Value was either too large or too small for an Int32.)

    int num2 = num1 % 10; //находим третью цифру получившегося трехзначного числа
    return Math.Abs(num2); // возвращаем модуль полученной третьей цифры, чтобы ответ не был отрицательным
}

Console.Write("Input your number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if((number1 > 99) || (number1 < -99))
{
    int result = Number(number1);
    Console.Write($"The third digit of your number is: {result}");
}
else
{
    Console.Write("There is no third digit in your number!");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да, 7 -> да, 1 -> нет
*/

void DayOfTheWeek(int number)
{
    if (number > 0 && number < 8)
        if (number > 0 && number <6)
        {
            Console.Write ("This day of the week is not a day off");
        }
        else
        {
            Console.Write ("This day of the week is a day off");
        }
    else
    {
        Console.Write ("Your number is not a day of the week");
    }
}

Console.Write("Input your number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek(num1);