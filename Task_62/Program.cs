// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

// Генерация пустого массива со случайным количеством строк [3...10] и столбцов [3...10]
int[,] GeneratingArray2D()
{
    Random rnd = new Random();
    int[,] array = new int[rnd.Next(3, 11), rnd.Next(3, 11)];
    return array;
}

// Заполнение массива по спирали
int[,] SpiralArray2DFilling(int[,] array)
{      
    int horizontalPass = 0,     // счетчик горизонтальных проходов
        verticalPass = 0,       // счетчик вертикальных проходов
        linePosition = 0,       // текущая позиция по строке
        columnPosition = 0,     // текущая позиция по столбцу           
        right = 0,              // счетчик шагов вправо
        down = 0,               // счетчик шагов вниз
        left = 0,               // счетчик шагов влево
        up = 0,                 // счетчик шагов вверх
        value = 1;              // значение
   
    while (array.GetLength(0) > horizontalPass && array.GetLength(1) > verticalPass) // пока есть куда двигаться
    {
        for (right = 0; right < array.GetLength(1) - verticalPass && value <= (array.GetLength(0) * array.GetLength(1)); ++right)
        {
            array[linePosition, columnPosition + right] = value;
            value++;
        }
        linePosition++;
        columnPosition = columnPosition + right - 1;
        horizontalPass++;

        for (down = 0; down < array.GetLength(0) - horizontalPass && value <= (array.GetLength(0) * array.GetLength(1)); ++down)
        {
            array[linePosition + down, columnPosition] = value;
            value++;
        }
        linePosition = linePosition + down - 1;
        columnPosition--;
        verticalPass++;

        for (left = 0; left < array.GetLength(1) - verticalPass && value <= (array.GetLength(0) * array.GetLength(1)); ++left)
        {
            array[linePosition, columnPosition - left] = value;
            value++;
        }
        linePosition--;
        columnPosition = columnPosition - left + 1;
        horizontalPass++;

        for (up = 0; up < array.GetLength(0) - horizontalPass && value <= (array.GetLength(0) * array.GetLength(1)); ++up)
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

int[,] array = GeneratingArray2D();
OutputingArray2D(array, "Пустой массив: ");
OutputingArray2D(SpiralArray2DFilling(array), "Заполненный массив: ");