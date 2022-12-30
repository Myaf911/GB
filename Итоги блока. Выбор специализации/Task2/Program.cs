using System;
using static System.Console;

Clear();

string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
		
int MaxWordLength = 3;

string[] GetShortWordsArray(string[] array)
{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
			
	for (int i = 0; i < length; i++)
	{
		if(array[i].Length <= MaxWordLength)
		{
			result[count] = array[i];
			count++;
		}
	}
	Array.Resize(ref result, count);
			
	return result;
}
		
void PrintArray(string[] array)
{
	if(array.Length == 0)
	{
		WriteLine("Массив пустой");
	}
	else
	{
		Array.ForEach(array, (str) => Write($"{str} "));
		WriteLine();
	}
}
		
void PrintTask(string[] array)
{
	WriteLine("\nИзначальный массив:");
	PrintArray(array);
	string[] shortArray = GetShortWordsArray(array);

    WriteLine($"\nМассив, длинна слов в котором меньше или равна {MaxWordLength} символа");
	PrintArray(shortArray);
	WriteLine();
}
		
PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);