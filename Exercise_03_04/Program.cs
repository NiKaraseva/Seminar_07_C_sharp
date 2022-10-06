/* Задача 1: Задайте двумерный массив. Найдите элементы, у которых 
оба индекса чётные, и замените эти элементы на их квадраты. */

/* Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, columns, 0, 15);
PrintArray(array);
Console.WriteLine();

int[,] array1 = NewArray(array);
PrintArray(array1);

int[,] NewArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] = (int) Math.Pow(array[i, j], 2); // Convert.TiInt32(Math.Pow(array[i, j, 2]))
            }
        }
    }
    return array;
} 


int[,] GetArray(int m, int n, int minValue, int maxValue)
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


void PrintArray(int[,] array)
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
*/


/* Задача 2: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. */ 

// int[,] array = GetArray(3, 3, 0, 10);

int rows = new Random().Next(3, 11);
int columns = new Random().Next(4, 11);
Console.WriteLine($"Получили количество строк = {rows}");
Console.WriteLine($"Получили количество столбцов = {columns}");

int[,] array = GetArray(rows, columns, 0, 10); 
PrintArray(array);
Console.WriteLine();
int Sum = GetSum(array);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {Sum}");


int GetSum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += array[i, j];

            }
        }
    }
    return sum;
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
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

void PrintArray(int[,] array)
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