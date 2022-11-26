// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArray(int size)
{
    int[] array1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(0, 100); 
    }

    return array1;
}

int [] array = GetArray(12);
Console.WriteLine("[" +String.Join(", ",array)+"]");

int sum = 0;

for (int i = 1; i < array.Length; i+=2)
    sum+=array[i];

Console.WriteLine(sum);
