//------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
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

//  Умножаем две матрицы
int[,] Multiplication2Arr(int[,] firstMatrix, int[,] secondMatrix)
{
      int[,] multiplArray = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
                multiplArray[i, j] = firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
    return multiplArray;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

int row = ReadData("Введите количество строк первой матрицы");
int column = ReadData("Введите количество столбцов первой матрицы");
int[,] arr2D = Gen2DArr(row, column, 10, 99);

Print2DArray(arr2D);

int row2 = ReadData("Введите количество строк второй матрицы");
int column2 = ReadData("Введите количество столбцов второй матрицы");
int[,] arr2D2 = Gen2DArr(row2, column2, 10, 99);

Print2DArray(arr2D2);

int[,] result = Multiplication2Arr(arr2D, arr2D2);
Print2DArray(result);