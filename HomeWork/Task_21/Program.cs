using System;
using static System.Console;

Clear();
WriteLine("Задача 21");
WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
WriteLine("A (3,6,8); B (2,1,-7), - > 15.84");
WriteLine("A (7,-5, 0); B (1,-1,9) - > 11.53");
WriteLine(" ");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
                {
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

WriteLine($"Длина отрезка  {segmentLength}");