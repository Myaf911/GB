Console.Clear();
Console.WriteLine("Задача 4");
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("введите число 1");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("введите число 2");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

Console.WriteLine("введите число 3");
string input3 = Console.ReadLine();
int number3 = Convert.ToInt32(input3);
int max = 0;

if (number1 > number2)
{
max = number1;
}

else
{
max = number2;
}

if (number3 > max)
{
max = number3;
}

Console.WriteLine("Максимальное - " + max);