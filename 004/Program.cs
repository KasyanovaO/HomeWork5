//Доп задание
//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

class Program
{
    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 1000);
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
        Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10,99] ");
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] >= 10 & array[i] <= 99)
            {
                count++;
            }
        Console.WriteLine($"{count}");
    }
}
