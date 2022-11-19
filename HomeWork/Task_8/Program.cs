Console.Clear();
Console.WriteLine("Задача 8");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("введите число");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
int count = 2;

Console.Write("Все чётные числа до вашего числа: ");

while (count <= number1)
{
Console.Write(count + " ");
count = count + 2;
}