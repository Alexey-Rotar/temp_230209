// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Генерация массива
int[,] GeneratingArray2D(uint lines, uint columns)
{
    Random rnd = new Random();
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10);
    }
    return array;
}

// Перемножение матриц
int[,] MultiplicationOfArrays(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                arrayC[i, j] = 0;
                for (int k = 0; k < arrayA.GetLength(1); k++)
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
        return arrayC;
    }
    else
    {
        int[,] arrayC = new int[1, 1];
        return arrayC;
    }
}

// Вывод массива
void OutputingArray2D(int[,] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] arrayA = GeneratingArray2D(5, 3);
int[,] arrayB = GeneratingArray2D(3, 4);
OutputingArray2D(arrayA, "Матрица A: ");
OutputingArray2D(arrayB, "Матрица B: ");
int[,] arrayC = MultiplicationOfArrays(arrayA, arrayB);
OutputingArray2D(arrayC, "Произведение матриц A и B: ");
