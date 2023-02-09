// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

// Заполнение массива по спирали
int[,] SpiralFillingArray2D(int[,] array)
{      
    int horizontalPass = 0;
    int verticalPass = 0;
    int linePosition = 0;
    int columnPosition = 0;
    int value = 1;
    int right = 0;
    int down = 0;
    int left = 0;
    int up = 0;

    while (array.GetLength(0) > horizontalPass && array.GetLength(1) > verticalPass)
    {
        for (right = 0; right < array.GetLength(1) - verticalPass; ++right)
        {
            array[linePosition, columnPosition + right] = value;
            value++;
        }
        linePosition++;
        columnPosition = columnPosition + right - 1;
        horizontalPass++;

        for (down = 0; down < array.GetLength(0) - horizontalPass; ++down)
        {
            array[linePosition + down, columnPosition] = value;
            value++;
        }
        linePosition = linePosition + down - 1;
        columnPosition--;
        verticalPass++;

        for (left = 0; left < array.GetLength(1) - verticalPass; ++left)
        {
            array[linePosition, columnPosition - left] = value;
            value++;
        }
        linePosition--;
        columnPosition = columnPosition - left + 1;
        horizontalPass++;

        for (up = 0; up < array.GetLength(0) - horizontalPass; ++up)
        {
            array[linePosition - up, columnPosition] = value;
            value++;
        }
        linePosition = linePosition - up + 1;
        columnPosition++;
        verticalPass++;
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
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}

int[,] array = new int[5, 10];
OutputingArray2D(array, "Пустой массив: ");
OutputingArray2D(SpiralFillingArray2D(array), "Заполненный массив: ");

