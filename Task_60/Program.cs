// Задача 60. *** ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());      //result[i,j] = new Random().Next(minValue, maxValue +1);
    return number;
}

int[,,] GetArray3D(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            for(int k = 0; k < z; k++)
            {
                result[i,j,k] = new Random().Next(minValue, maxValue +1);
            }
        }
    }
    return result;
}

void PrintArray3D(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }
    }
    
}
int x = Prompt("Введите координаты X");
int y = Prompt("Ввведите координаты Y");
int z = Prompt("Ввведите координаты Z");
int minValue = Prompt("Введите минимальное значение в массиве");
int maxValue = Prompt("Введите максимальное значение в массиве");
Console.WriteLine();
int [,,] array3D = GetArray3D(x, y, z, minValue, maxValue);
PrintArray3D(array3D);


