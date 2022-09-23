/* ------------------------------------------------------------------
Задача 38:  Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
-------------------------------------------------------------------*/
// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// печатаем одномерный массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Универсальный метод генерации и заполнения массива
    double [] FillArray(int num)
{
    //Генератор случайных чисел
    Random numSintezator = new Random();
    //Создаем массив
    double[] arr = new double[num];
    //Заполняем массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(numSintezator.NextDouble(), 2);
    }
    //Возвращаем результат
    return arr;
}
// Метод определения разницы между элементами
double MaxMin(double[] array)
{
   double max = int.MinValue;
    double min = int.MaxValue;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max - min);
}




int arrayLength = ReadData("Введите длину масива");
double[] inputArray = FillArray(arrayLength);
Print1DArr(inputArray);
double outArr = MaxMin(inputArray);
Console.WriteLine(outArr);

