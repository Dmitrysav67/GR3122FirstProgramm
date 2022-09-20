//------------------------------------------------------------------
// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных 
// и положительных элементов массива.
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

int[] NegotivPositivSum(int[] arr)
{
    int[] sum = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum[0] += arr[i];
        }
    else
    {
    sum[1] += arr[i];
    }
}
return sum;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}


int arrayLength =ReadData("Введите длину масива");
int downBorder =ReadData("Введите нижнюю границу");
int topBorder =ReadData("Введите верхнюю границу");
int [] inputArray = FillArray(arrayLength, downBorder, topBorder);
Print1DArr(inputArray);
int [] sumArray = NegotivPositivSum (inputArray);
PrintResult("Сумма >0:"+ sumArray[0]+ "Сумма <0:"+sumArray[1]);
Print1DArr(sumArray);


