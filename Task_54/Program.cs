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

void Print(string text)
{
    Console.Write(text);
}

int UserNum()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

Print("Введите количество строк массива: ");
int row = UserNum();
Print("Введите количество столбцов массива: ");
int col = UserNum();
Print("Введите минимальное число массива: ");
int min = UserNum();
Print("Введите максимальное число массива: ");
int max = UserNum();

Console.Clear();

int[,] FillAndPrintArray(int row, int col, int min, int max)
{
    int[,] numbers = new int[row, col];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine();
    }
    return numbers;
}

void PrintArrayMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}



int[,] numbers = FillAndPrintArray(row, col, min, max);
Console.WriteLine();
SortArray(numbers);
PrintArrayMatrix(numbers);