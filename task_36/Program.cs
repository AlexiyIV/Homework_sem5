//Задача 36. Задайте массив заполненный случайными числами.
//Напсать программу, котортая покажет сумму элементов стоящих на нечётных позициях
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

int SumNotParityIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

int N = GetData("Введите длину массива N=");
int Min = GetData("Введите минимальный элемент массива Min=");
int Max = GetData("Введите максимальный элемент массива Max=");
if (N < 0 || Min > Max) Console.WriteLine("Неверные данные");
else
{
    int[] Arr = FillArr(N, Min, Max);
    PrintArr(Arr);
    Console.WriteLine("Сумма чисел на нечётных позициях =" + SumNotParityIndex(Arr));
}

