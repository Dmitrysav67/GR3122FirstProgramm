//------------------------------------------------------------------
// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их квадраты.
//-------------------------------------------------------------------
// Печать 2D массива.
void Print2DArr(int[,] arr, string message = "Массив: ")
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
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

//
int[,] EvenToSquere(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i+=2)
    {
        for (int j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        }        
    }
    return arr;
}

// Делаем квадраты
int[,] Change2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matr[i, j] = (int)Math.Pow(matr[i, j], 2);
            }

        }
    }
    return matr;
}

// Метод для замера времени.
void TimeTest(Func<int[,], int[,]> Method, int[,] arr, string funcName , int count=1)
{
    DateTime start = DateTime.Now;
    for (int i = 0; i < count; i++)
    {
        Method(arr);
    }
    
    Console.WriteLine($"Затраченное время метода {funcName}: {(DateTime.Now - start).TotalMilliseconds} ms");
}  


int[,] arr = Gen2DArr(10, 10, 0, 10);

TimeTest(EvenToSquere, (int[,])arr.Clone(), "EvenToSquere", 1000000);
TimeTest(Change2DArray, (int[,])arr.Clone(), "Change2DArray", 1000000);