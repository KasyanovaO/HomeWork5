//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

class Program
{
    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(100, 1000);
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                Console.Write(arr[i] + "");
            }
            else
            {
                Console.Write(arr[i] + ", ");
            }
        }
        Console.Write("]");

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        FillArray(array);
        Console.WriteLine("Массив");
        PrintArray(array);
        Console.WriteLine();
        Console.WriteLine("Количество четных чисел в массиве ");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] % 2 == 0)
            {
                count++;
            }
        Console.WriteLine($"{count}");
    }
}

