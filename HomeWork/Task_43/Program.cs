using System;
using static System.Console;

Clear();
WriteLine("Задача 43");
WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями \ny = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
WriteLine("\nb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)");

Write("\nВведите b1: ");
var b1 = Convert.ToDouble(ReadLine());
Write("\nВведите k1: ");
var k1 = Convert.ToDouble(ReadLine());
Write("\nВведите b2: ");
var b2 = Convert.ToDouble(ReadLine());
Write("\nВведите k2: ");
var k2 = Convert.ToDouble(ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
WriteLine($"\nПересечение в точке: ({x} ; {y}) ");

