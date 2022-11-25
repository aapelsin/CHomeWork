// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int NumPow(int n1, int n2)
{
        int count = 1;
        int res = n1;

    while (count<n2)
    {
        count++;
        res*=n1;
    }
    return res;
}

Console.WriteLine(NumPow(num1, num2));