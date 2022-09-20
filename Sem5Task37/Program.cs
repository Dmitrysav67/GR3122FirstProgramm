//------------------------------------------------------------------
// Задача 37: Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
//-------------------------------------------------------------------


// печатаем одномерный массив
void Print1DArr(int[] arr)
{
    Console.Write("["+arr[0]+",");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + ", ");
    Console.WriteLine();
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
        for (int i = 0; i < num; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    // Возвращаем результат
    return arr;
}

// Метод считывания числа
int [] MultTask(int[] arr)
{
    int[] arrMult = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrMult[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return arrMult;
}


int[] arr = FillArray(50, 1, 1000);
Print1DArr(arr);
int [] outArr=MultTask(arr);
Print1DArr(outArr);
