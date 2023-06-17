// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j]}; ");
        Console.WriteLine();
    }
    
}



int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int [rowsA, columnsB];
    if(matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for(int i = 0; i < rowsA; i++)
        {
            for(int j = 0; j < columnsB; j++)
            {
                for(int n = 0; n < matrixA.GetLength(1); n++)
                {
                    result[i,j] += matrixA[i,n] * matrixB[n,j];
                }
            }
        }
    }
    return result;
}

int rowsA = Prompt("Введите колличество строк в массиве A");
int columnsA = Prompt("Введите колличество столбцов в массиве A");
int minValueA = Prompt("Введите минимальное значение в массиве A");
int maxValueA = Prompt("Введите максимальное значение в массиве A");
int [,] matrixA = GetArray(rowsA, columnsA, minValueA, maxValueA);

int rowsB = Prompt("Введите колличество строк в массиве B");
int columnsB = Prompt("Введите колличество столбцов в массиве B");
int minValueB = Prompt("Введите минимальное значение в массиве B");
int maxValueB = Prompt("Введите максимальное значение в массиве B");
int [,] matrixB = GetArray(rowsB, columnsB, minValueB, maxValueB);
Console.WriteLine("Массив A");
PrintArray(matrixA);
Console.WriteLine("Массив B");
PrintArray(matrixB);
Console.WriteLine("Произведение двух матриц");
int [,] result = MatrixMult(matrixA, matrixB);
PrintArray(result);