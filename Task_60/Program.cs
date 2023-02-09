// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Генерация 3D-массива 
int[,,] GeneratingArray3D(uint x, uint y, uint z)
{
    int value = 10;
    //Random rnd = new Random();
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = value;
                value += 1;
                //array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

// Вывод 3D-массива
void OutputingArray3D(int[,,] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] array = GeneratingArray3D(4, 4, 5);
OutputingArray3D(array, "Сгенерированный массив:");