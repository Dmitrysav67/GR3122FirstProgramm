//------------------------------------------------------------------
// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
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

// Нахождение числа в массиве
bool FindElement(int[] arr, int elm)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            return true;
        }
    }
    return false;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrayLength = ReadData("Введите длину массива:");
int start = ReadData("Введите минимальное значение:");
int stop = ReadData("Введите максимальное значение:");
int elm = ReadData("Введите элемент:");
int[] arr = FillArray(arrayLength, start, stop);
Print1DArr(arr);
PrintResult(elm+"->"+FindElement(arr,elm));
