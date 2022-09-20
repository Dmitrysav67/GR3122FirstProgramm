//------------------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
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
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    // Возвращаем результат
    return arr;
}

// Метод нахождения суммы элементов
int[] OddPositionSumm(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return arr;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int arrayLength = ReadData("Введите длину масива");
int downBorder = ReadData("Введите нижнюю границу");
int topBorder = ReadData("Введите верхнюю границу");
int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(inputArray);
int[] sumArray = OddPositionSumm(inputArray);
PrintResult("Сумма элементов, стоящих на нечётных позициях:" + sumArray[0]);






