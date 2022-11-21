using System;
using static System.Console;

Clear();
WriteLine("Задача 4");
WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
WriteLine("2, 3, 7 -> 7");
WriteLine("44 5 78 -> 78");
WriteLine("22 3 9 -> 22");
WriteLine(" ");
WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(ReadLine());

WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    WriteLine("Максимальное число: " + secondNumber);
}
else
{
    WriteLine("Максимальное число: " + thirdNumber);
}