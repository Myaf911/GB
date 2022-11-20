Console.Clear();
Console.WriteLine("Задача 19");
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("14212 - > нет");
Console.WriteLine("12821 - > да");
Console.WriteLine("23432 - > да");
Console.WriteLine(" ");
Console.WriteLine("Задача 19");
Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - Да, это точно палиндром!");
  }
  else Console.WriteLine($"Ваше число: {number} - Нет, это точно не палиндром :( ).");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
