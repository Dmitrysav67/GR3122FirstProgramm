//------------------------------------------------------------------
// Задача№ 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве
//-------------------------------------------------------------------

// чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// печатаем одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + ", ");
}

// Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    // Создаем массив
    int[] arr = new int[num];
    // Тест границ
    if (downBorder < topBorder)
    {
        // Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder);
        }
    }
    // Возвращаем результат
    return arr;
}

int[] QuantNegotivPositiv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return arr;
}

    //Печать результата
    void PrintResult(string line)
    {
        Console.WriteLine(line);
    }


    int arrayLength = ReadData("Введите длину масива");
    int downBorder = ReadData("Введите нижнюю границу");
    int topBorder = ReadData("Введите верхнюю границу");
    int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
    Print1DArr(inputArray);
    int[] qntArray = QuantNegotivPositiv(inputArray);
    PrintResult("Количество четных чисел:" + qntArray[1]);

