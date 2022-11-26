// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetArray(int size)
{
    int[] array1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(0, 1000); 
    }

    return array1;
}

int [] array = GetArray(12);
Console.WriteLine("[" +String.Join(", ",array)+"]");

int count = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i]%2==0) count++;

Console.WriteLine(count);
