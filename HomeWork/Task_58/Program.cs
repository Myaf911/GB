using System;
using static System.Console;

Clear();
WriteLine($"Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\nНапример, заданы 2 массива:\n1 4 7 2\n5 9 2 3\n8 4 2 4\n5 2 6 7\nи\n1 5 8 5\n4 9 4 2\n7 2 2 6\n2 3 4 7");
WriteLine($"\nИх произведение будет равно следующему массиву: \n 1 20 56 10\n 20 81 8 6\n 56 8 4 24\n 10 6 24 49");


WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("\nВведите число строк 1-й матрицы: ");
int n = InputNumbers("\nВведите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("\nВведите число столбцов 2-й матрицы: ");
int range = InputNumbers("\nВведите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Write(array[i,j] + " ");
    }
    WriteLine();
  }
}