using System;
using static System.Console;

Clear();
WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");
WriteLine($"\nНапример, на выходе получается вот такой массив:\n1 2 3 4\n12 13 14 5\n11 16 15 6\n10 9 8 7");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteLine("\nПолучается вот такой массив:");
WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Write($" {array[i,j]} ");

      else Write($"{array[i,j]} ");
    }
    WriteLine();
  }
}