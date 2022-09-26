// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int[,] numbers = new int[row, col];
Console.Clear();

void FillArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            numbers[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        minRow += numbers[0, i];
    }
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++) sumRow += numbers[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Наименьшая сумма элементов в строке {minSumRow + 1}");
}

FillArray(numbers);
PrintArray(numbers);
MinSum(numbers);
