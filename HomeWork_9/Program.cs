// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Вввеите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вввеите координату y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вввеите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вввеите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вввеите координату y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вввеите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double num = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(z2-z1,2)); 
Console.Write(num);