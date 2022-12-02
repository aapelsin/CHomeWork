// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число от ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число до ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Sum(num1, num2));

int Sum(int n1, int n2)
{
    if (n1 == n2) return n1;
    return (n1 + Sum(n1 + 1, n2));
}