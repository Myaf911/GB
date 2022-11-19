Console.Clear();
Console.WriteLine("Задача 6");
Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("введите число");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

if ((number1 % 2) ==0 )
{
Console.WriteLine("ДА - число чётное");
}

else
{
Console.WriteLine("НЕТ - число не чётное");
}