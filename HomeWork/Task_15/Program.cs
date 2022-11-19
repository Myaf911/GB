Console.Clear();
Console.WriteLine("Задача 15");
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("6 - > да");
Console.WriteLine("7 - > да");
Console.WriteLine("1 - > нет");
Console.WriteLine(" ");
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("да - этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("нет - этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);