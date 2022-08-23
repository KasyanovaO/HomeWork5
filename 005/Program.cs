//Доп задание
//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


class Program
{


    static void FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 10);
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
        Console.WriteLine("Новый массив ");
        int[] newarray = new int[array.Length];
        int p = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - i - 1)
            {
                p = array[i] * array[array.Length - i - 1];
                newarray[i] = p;
            }
            if (i == array.Length - i - 1)
            {
                p = array[i] * 1;
                newarray[i] = p;
            }
        }

        PrintArray2(newarray);

    }
    static void PrintArray2(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i <= array.Length - i - 1; i++)
        {
            if (i == (array.Length - 1) / 2)
            {
                Console.Write(array[i] + "");
            }
            else
            {
                Console.Write(array[i] + ", ");
            }

        }
        Console.Write("]");
    }
}

