Console.Clear();
Console.WriteLine("Задача 13");
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("645 - > 5");
Console.WriteLine("78 - > третьего числа нет");
Console.WriteLine("32679 - > 6");
Console.WriteLine(" ");
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> тут всего 2 числа, где третье???");
}