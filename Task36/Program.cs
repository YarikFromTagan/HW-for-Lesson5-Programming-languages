/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int n, int mn, int mx)
{
    int [] arr = new int[n];
    for(int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(mn, mx + 1);
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b]");
    Console.WriteLine();
}

int SumOddElemet(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i += 2)
        sum += arr[i];
    return sum;
}

Console.Clear();
Console.Write("Введите размер массива size = ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива min = ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива max = ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[] Array = CreateArray(size, min, max);
Console.WriteLine($"Массив размерности {size} со случайными элементами в интервале от {min} до {max}");
PrintArray(Array);

Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна {SumOddElemet(Array)} ");
Console.WriteLine();
