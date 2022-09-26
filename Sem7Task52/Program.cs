//------------------------------------------------------------------
// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
//-------------------------------------------------------------------

// Чтение данных из консоли

int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
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

// Печать двухмерного массива.
void Print2DArr(int[,] arr, string message = "Массив: ")
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

// Печать одномерного массива.
void Print1DArray(double[] arr)
{
    string arrString = String.Empty;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }

    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

// Создание одномерного массива 
double[] Array(int[,] arr)
{
   double[] massiv = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            massiv[j] += arr[i, j];
        }
    }

    return ArithMean(massiv, arr.GetLength(0));
}

// Среднее арифметическое
double[] ArithMean(double[] arr, int numbers)
{
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = (arr[k] / ((double)arr.GetLength(0)));
    }
    return arr;
}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] arr2D = Gen2DArr(row, column, 10, 99);
Print2DArr(arr2D);
Print1DArray( Array(arr2D));
