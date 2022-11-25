using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Задача 4");
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("2, 3, 7 -> 7");
Console.WriteLine("44 5 78 -> 78");
Console.WriteLine("22 3 9 -> 22");
Console.WriteLine(" ");
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    } 
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}