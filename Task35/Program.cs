﻿// Задайте одномерный массив 
// из 123 случайных чисел
// Найдите количество элементов массива
// значения которых лежат в отрезке [10,99]
// [5,18,123,6,2] -> 1
// [1,2,3,6,2] -> 0
// [10,11,12,13,14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}
int[] arr = CreateArrayRndInt(5, 0, 123);
PrintArray(arr);
int count = Count(arr);
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");

