// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int rows = Prompt("Введите колличество строк в массиве ");
int columns = Prompt("Введите колличество столбцов в массиве ");
int minValue = Prompt("Введите минимальное значение в массиве ");
int maxValue = Prompt("Введите максимальное значение в массиве ");
int [,] array = GetArray(rows, columns, minValue, maxValue);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int rowNomber = GetRowNomber(array);
Console.Write($"Наименьшая сумма элементов в строке {rowNomber}");


int GetRowNomber(int [,] array)
{
    int row = 0;
    int minSum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0,i];                   // Посчитали минимальную сумму, как точку отсчета
    }
    Console.Write($"{minSum} ");
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        Console.Write($"{sum} ");
    
    if(minSum > sum)
    {
        minSum = sum;
        row = i;
    }
    }
    return row + 1;         // +1 чтобы вышел номер строки, а не индекс
}
