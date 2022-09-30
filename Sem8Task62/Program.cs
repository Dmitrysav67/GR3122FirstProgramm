//------------------------------------------------------------------
// Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
// Пока не решено
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
            Console.Write($"{matr[i, j]}\t");
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



int row = ReadData("Введите количество строк первой матрицы");
int column = ReadData("Введите количество столбцов первой матрицы");
int[,] arr2D = Gen2DArr(row, column, 10, 99);

Print2DArray(arr2D);
