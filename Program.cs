//Урок 7. Как не нужно писать код.
// Задача 47. Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

void Ex47() 
{
int m = 4;
int n = 4;
int[,]array =  new int [m,n];

void PrintArray(int[,] array)
{
    for (int i =0; i< array.GetLength(0); i++)
    {
        for (int j =0; j< array.GetLength(1); j++) 
        {
          Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i =0; i< array.GetLength(0); i++)
    {
        for (int j =0; j< array.GetLength(1); j++) 
        {
            array[i,j]= new Random().Next(-10,10);
        }
    }
}

FillArray(array);
Console.WriteLine();
PrintArray(array);
}
Ex47();

// Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> число с таким адресом в массиве нет

void Ex50()
{
    int m = 7;
    int n = 7;
    int[,] GetArray(int m, int n)
    {
        int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(1, 10);
            }
        }
        return result;
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void FindElement(int[,] array)
    {
        Console.WriteLine("Введите индекс строки:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите индекс столбца:");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == x && j == y)
                {
                    Console.WriteLine($"Элемент с такими индексами равен {array[i, j]} ");
                }
            }
        }
        if (x >= m || y >= n)
        {
            Console.Write("Элемента с такими индексами в массиве нет");
        }
    }

    int[,] array = GetArray(m, n);
    PrintArray(array);
    FindElement(array);
}
Ex50();
// Задача 52
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void Ex52()
{
int[,] array = { { 4, 1, 3, 6 }, { 9, 5, 1, 4 }, { 6, 5, 4, 1 } };

void PrintAverage()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }

        average = average / array.GetLength(0);
        Console.Write($"{average: 0.00}\t");
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}
PrintArray();
PrintAverage();
}
Ex52();