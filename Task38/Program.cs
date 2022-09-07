/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] CreateArray(int sz, int mn, int mx)
{
    double[] arr = new double[sz];
    for(int i = 0; i < sz; i++)
    {
        double IntPart = new Random().Next(mn, mx + 1);
        double FractPart = new Random().NextDouble();
        arr[i] = IntPart + FractPart;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine("\b\b]");
}

double FindDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    double diff = max - min;
    return diff;
    //return max;
    //return min;
}

Console.Clear();
Console.Write("Введите размер массива size = ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива min = ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива max = ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

double[] Array = CreateArray(size, min, max);
Console.WriteLine($"Массив размерности {size} со случайными элементами в интервале от {min} до {max}");
PrintArray(Array);

double difference = FindDiff(Array);
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива");
Console.WriteLine($"равна {difference}");



