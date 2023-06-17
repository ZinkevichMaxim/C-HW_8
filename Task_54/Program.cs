﻿
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



void GetSortArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) -1; k++)
            {
                if(array[i,k] < array[i, k+1])
                {
                    int temp = array[i,k+1];
                    array [i,k +1] = array[i, k];
                    array[i,k] = temp;
                }
            }
        }
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
GetSortArray(array);
PrintArray(array);
Console.WriteLine();
