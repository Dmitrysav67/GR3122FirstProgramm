// ---------------------------------------------------------------------
//                                 Задача 45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.
// ---------------------------------------------------------------------


// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}


int[] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i];
    }
    return outArr;
}

int[] arr = GenArray(20, 1, 100);
PrintArray(arr);
int[] copyArr = CopyArr(arr);
PrintArray(copyArr);


PrintArray((int[])arr.Clone());



//==================================================================


// int length = ReadData("Задайте длину массива: ");
// int[] array = CreateRandomArray(length);
// Print1DArray(array);
// PrintResult("Копия массива");
// Print1DArray(MakeArrayCopy(array));

// PrintResult("Копия массива Clone");
// Print1DArray((int[])array.Clone());


// // Получение данных от пользователя и преобразование в число
// int ReadData(string text)
// {
//     Console.Write(text);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Вывод результата в консоль
// void PrintResult(string data)
// {
//     Console.WriteLine(data);
// }

// // Создание и заполнение массива числами
// int[] CreateRandomArray(int leng)
// {
//     int[] array = new int[leng];
//     Random rnd = new Random();

//     for (int i = 0; i < leng; i++)
//     {
//         array[i] = rnd.Next(-1000, 1000);
//     }
//     return array;
// }

// // Вывод массива в консоль
// void Print1DArray(int[] arr)
// {
//     Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
// }

// int[] MakeArrayCopy(int[] arr)
// {
//     int[] rev = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         rev[i] = arr[i];
//     }
//     return rev;
// }