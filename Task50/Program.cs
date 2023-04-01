// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такой позиции нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции нет

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1; 10]
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// Console.Clear();

// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     Console.WriteLine("Введите позицию элемента: ");
//     int[] pos = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();  
//     int[,] matrix = new int[size[0], size[1]];

// InputMatrix(matrix);
// Console.WriteLine("Начальный массив");
// PrintMatrix(matrix);
// Console.WriteLine();
// if(pos[0]<size[0]||pos[1]<size[1])
//     Console.WriteLine($"Ответ: {matrix[pos[0],pos[1]]}");
// else
// Console.WriteLine("Такой позиции нет");

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1; 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();

Console.Write("Введите позицию элемента: ");

    int[] pos = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();  
    int[,] matrix = new int[10, 10];

InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
Console.WriteLine();
if (pos[0]>matrix.GetLength(0)||pos[1]>matrix.GetLength(1))
    Console.WriteLine("Такой позиции нет");
else
Console.WriteLine($"Ответ: {matrix[pos[0],pos[1]]}");