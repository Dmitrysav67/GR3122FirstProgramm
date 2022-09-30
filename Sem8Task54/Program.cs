//------------------------------------------------------------------
// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива
//-------------------------------------------------------------------
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Генерация случайного двумерного массива.
int[,] Gen2DArr(int arrLen, int arrDepth, int arrMin, int arrMax)
{
    int[,] arr = new int[arrLen, arrDepth];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        {   
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}


//  Упорядочевание строк по убыванию
int[,] UpdateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Row.Add(array[i, j]);
            Row.Sort(); 
            Row.Reverse(); 
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Row[j];
        }
    }
    return array;
}


int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] arr2D = Gen2DArr(row, column, 10, 99);

Print2DArray(arr2D);

UpdateArray(arr2D);
Print2DArray(arr2D);