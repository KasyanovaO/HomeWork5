//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

class Program
{
    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(-100, 100);
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
        Console.WriteLine("Cумма элементов, стоящих на нечётных позициях ");
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            if (i % 2 == 1)
            {
                sum = sum + array[i];
            }
        Console.WriteLine($"{sum}");
    }
}

