// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 10 ");

Console.Write("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
string a1 = Convert.ToString(a);
if (a1.Length > 1)
{
    Console.WriteLine("Вторая цифра : " + a1[1]);
}
else
{
    Console.WriteLine(a1 + "-В этом числе второй цифры нет");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задача 13 ");
Console.Write("Введи число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
string a3 = Convert.ToString(a);
if (a1.Length > 2)
{
    Console.WriteLine("третья цифра - " + a1[2]);
}
else
{
    Console.WriteLine("- третьей цифры нет");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру деня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(этот день выходной) -> да");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("это не день недели");
    }
    else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);

