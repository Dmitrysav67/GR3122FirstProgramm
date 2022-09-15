//------------------------------------------------------------------
// Задача 30: Напишите программу, которая выводит массив из 8 
// элементов, заполненный нулями и единицами в случайном порядке.
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


void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length-1] + ", ");
}

int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

int arrLen = ReadData("Введите длину массива:");
int[] array = GenArr(arrLen);
PrintArr(array);
PrintArr(GenArr(ReadData("Введите число")));


