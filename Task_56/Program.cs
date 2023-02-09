// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Генерация массива
int[,] GeneratingArray2D()
{
    Random rnd = new Random();
    int[,] array = new int[7, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10);
    }
    return array;
}

// Вывод массива с указателем на строку
void OutputingArray2D(int[,] array, int marker, string message, string markerMessage)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
            if (i == marker && j == array.GetLength(1) - 1)
                Console.Write(markerMessage);
        }
        Console.WriteLine();
    }
}

// Поиск индекса строки с наименьшей суммой элементов
int GettingMinSumAmongLinesArray2D(int[,] array)
{
    int indexOfMinSum = 0, minSum = 0, temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < array.GetLength(1); temp += array[i, j++]) { }
        if (i == 0 || temp < minSum)
        {
            minSum = temp;
            indexOfMinSum = i;
        }
    }
    return indexOfMinSum;
}

int[,] array = GeneratingArray2D();
int indexOfMinSum = GettingMinSumAmongLinesArray2D(array);
OutputingArray2D(array, indexOfMinSum, "Сгенерированный массив: ", "<- строка с наименьшей суммой элементов (" + indexOfMinSum + ")");