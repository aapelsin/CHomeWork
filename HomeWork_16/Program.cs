// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] GetArray(int size)
{
    double[] array1 = new double[size];

    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().NextDouble();
        array1[i]+=new Random().Next(1, 10);
        array1[i] = Math.Round(array1[i], 2);
    }

    return array1;
}

double [] array = GetArray(5);
Console.WriteLine("[" +String.Join(", ",array)+"]");

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
    if (array[i]<min) min = array[i];
        else 
            if (array[i]>max) max = array[i];
    
Console.WriteLine("Max = " +max);
Console.WriteLine("Min = " +min);
Console.WriteLine("Max - min= " +(max-min));