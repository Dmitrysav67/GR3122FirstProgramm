//------------------------------------------------------------------
// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
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


/// Генерация случайного двумерного массива.
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


// Нахождение числа в двухмерном массиве
int FindElem(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) &&
    y < array2D.GetLength(1))
    {
        return array2D[x, y];
    }
    else
    {
        return -1;
    }
}
//Печать результата 
void PrintResult(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) && y < array2D.GetLength(1))
    {
        Console.WriteLine(array2D[x, y]);
    }
    else
    {
        Console.WriteLine("Элемента нет");
    }
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


int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
Console.WriteLine();

int[,] arr2D = Gen2DArr(row, column, 10, 99);
Print2DArr(arr2D);
int x = ReadData("Введите номер строки: ") - 1;
int y = ReadData("Введите номер столбца: ") - 1;
int elem = FindElem(x, y, arr2D);
PrintResult(x, y, arr2D);