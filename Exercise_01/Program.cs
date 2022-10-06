/* Задайте двумерный массив размером mxn,
заполненный случайными целыми цислами */

Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);



int[,] GetArray(int m, int n, int minValue, int maxValue) // задаём метод для заполнения двумерного массива
// int m и int m – строки и столбцы соответственно
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array) // метод для ВЫВОДА двумерного массива 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
    

