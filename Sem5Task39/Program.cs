//------------------------------------------------------------------
// Задача 38:  Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
//-------------------------------------------------------------------


// печатаем одномерный массив
void Print1DArr(double[] arr)
{
    Console.Write("[" + arr[0] + ",");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + ", ");
    Console.WriteLine();
}

// Универсальный метод генерации и заполнения массива
double[] FillArray(double num, double downBorder, double topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    // Создаем массив
    double[] arr = new double[num];
    // Тест границ
    if (downBorder < topBorder)
    {
        // Заполняем массив
        for (double i = 0; i < num; i++)
        {
            arr[i] = numSintezator.NextDouble(downBorder, topBorder + 1);
        }
    }
    // Возвращаем результат
    return arr;
}

// Метод определения разницы между элементами
double[] MaxMin(double num)
{
    double[] arr = new double[num];
    double A = 0;
    double max = double.MinValue;
    double min = double.MaxValue;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return max - min;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}


double[] arr = FillArray(50, 1, 1000);
Print1DArr(arr);
double[] outArr = MaxMin(arr);
Print1DArr(outArr);