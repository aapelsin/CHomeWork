// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] matrix = new int [new Random().Next(3,9), new Random().Next(3,9)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,12);
        Console.Write(matrix[i,j]+ " ");

    }
    Console.WriteLine();
}

Console.Write("Введите позицию элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
bool b = false;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i==xrow && j==xcolum) b = true;
    }
}

if (b == true) Console.Write("Элемент с позицией " +x+ " есть в массиве");
if (b == false) Console.Write("Элемента с позицией " +x+ " нет в массиве");