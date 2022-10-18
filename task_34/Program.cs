//Задача 34. Задайте массив заполненный случайными трёхзначными числами.(Min=100, Max=999)
//Напсать программу, котортая покажет количество чётных чисел в массиве.
int[] FillArr(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int GetData(string msg)
{
    Console.Write(msg);
    int data = int.Parse(Console.ReadLine());
    return data;
}

int CountParity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int N = GetData("Введите длину массива N=");
int Min = GetData("Введите минимальный элемент массива Min=");
int Max = GetData("Введите максимальный элемент массива Max=");

if (N <= 0 || Min >= Max)
{
    Console.Write("Неверные вводные");
}
else
{
    int[] Arr = FillArr(N, Min, Max);
    int C = CountParity(Arr);
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.WriteLine();
    Console.Write("количество чётных чисел в массиве " + C);
}
