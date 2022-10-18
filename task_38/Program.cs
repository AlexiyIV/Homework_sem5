//Задача 38. Задайте массив заполненный случайными числами.
//Напсать программу, котортая покажет разницу между максимальным и минимальным элементом
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

int DifferenceMinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        else if (arr[i] > max) max = arr[i];
    }
    int diff = max - min;
    return diff;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int N = GetData("Введите длину массива N=");
int Min = GetData("Введите минимальный элемент массива Min=");
int Max = GetData("Введите максимальный элемент массива Max=");
if (N <= 0 || Min > Max) Console.WriteLine("Неверные данные");
else
{
    int[] Arr = FillArr(N, Min, Max);
    PrintArr(Arr);
    Console.WriteLine("Разница между максимальным и минимальным элементом =" + DifferenceMinMax(Arr));
}
