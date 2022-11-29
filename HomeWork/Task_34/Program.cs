using System;
using static System.Console;

Clear();
WriteLine("Задача 34");
WriteLine(" ");
WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. \nНапишите программу, которая покажет количество чётных чисел в массиве.");
WriteLine("[345, 897, 568, 234] -> 2");
WriteLine(" ");

WriteLine("Рандомный массив: ");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Write(array[i] + " ");
  }
  WriteLine();
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
WriteLine();

int quantity = QuantityPositive(numbers);
WriteLine($"Количество чётных чисел в массиве: {quantity}");
WriteLine(" ");