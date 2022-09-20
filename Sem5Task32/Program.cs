//------------------------------------------------------------------
// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
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
            arr[i] = numSintezator.Next(downBorder, topBorder+1);
        }
    }
    // Возвращаем результат
    return arr;
}

// Изменение массива (разворот)
int[] inversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i]*= -1;
}
return arr;
}


int arrayLength=ReadData("Введите длину массива:");
int start=ReadData("Введите минимальное значение:");
int stop=ReadData("Введите максимальное значение:");

int [] arr = FillArray (arrayLength, start, stop);
Print1DArr (arr);
Print1DArr(inversArray(arr));
