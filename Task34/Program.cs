/*
Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArray(int sz)
{
    int[] arr = new int[sz];
    for(int i = 0; i < sz; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b]");
}

int NumEvenElements(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] % 2 == 0)
            count ++;
    return count;
}

Console.Clear();
Console.WriteLine("Введите размер массива, заполненного случайными положительными трёхзначными числами,");
Console.Write("который Вы хотите создать size = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] Array = CreateArray(size);

Console.WriteLine($"В созданном массиве");

PrintArray(Array);

Console.WriteLine($"имеется {NumEvenElements(Array)} четных элементов");
Console.WriteLine();
