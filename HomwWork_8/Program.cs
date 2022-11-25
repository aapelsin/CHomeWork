// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число - ");
string numText = Console.ReadLine();

if (numText.Length == 5)
{
    if (numText[0] == numText[4] && numText[1] == numText[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Ошибка. Нужно ввести пятизначное число!");
}
