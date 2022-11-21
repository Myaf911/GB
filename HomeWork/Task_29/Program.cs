using System;
using static System.Console;

Clear();
WriteLine("Задача 29");
WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
WriteLine("1, 2, 5, 7, 19 - > [1, 2, 5, 7, 19]");
WriteLine("6, 1, 33 - > [6, 1, 33]");
WriteLine(" ");
WriteLine("Программа, создающая массив из N введённых в консоль чисел\nВам необходимо ввести N целых чисел.\n \nДля завершения создания массива, напиши слово:\nстоп\n");

int count = 1;
List<int> array = new List<int>();

while(true) 
{
    WriteLine("Введите " + count + "-е число:");
        string str = ReadLine();
        if(str == "стоп")   // Комманда завершающая бесконечный ввод числа N
        {
            break;
        }
        if(int.TryParse(str, out int number)) 
        {
            array.Add(number);
            count++;
            continue;
        }
        else 
        {
            WriteLine("Некорректно указано число!\n");
            continue;
        }
}

WriteLine("Вы создали массив: "); Print(array);

void Print(List<int> array)
{
    for(int index = 0; index < count - 1; index++) 
    {
        if(index == 0) Write("[" + array[index] + ", ");    // Запятая за первым числом
        else 
        
        if (index == count - 2) Write(array[index] + "]!"); // Строка выдачи
        else Write(array[index] + ", "); // Запятая за всеми остальными числами кроме первого
    }
}