// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Генерация массива
int[,] GeneratingArray2D()
{
    Random rnd = new Random();
    int[,] array = new int[rnd.Next(2, 11), rnd.Next(2, 11)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10);
    }
    return array;
}

// Вывод массива
void OutputingArray2D(int[,] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

// Сортировка
int[,] SortingLineValuesMaxToMinArray2D(int[,] array)
{
    int indexOfMax, temp;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        indexOfMax = k;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = k; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, indexOfMax])
                    indexOfMax = j;
            }
            temp = array[i, indexOfMax];
            array[i, indexOfMax] = array[i, k];
            array[i, k] = temp;
        }
    }
    return array;
}

int[,] array = GeneratingArray2D();
OutputingArray2D(array, "Исходный массив: ");
array = SortingLineValuesMaxToMinArray2D(array);
OutputingArray2D(array, "Отсортированный массив: ");