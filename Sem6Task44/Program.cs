//------------------------------------------------------------------
// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1
//-------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

string FibNum(int num)
{
    string res = "";
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + first;
        buf = first + last;
        first = last;
        last = buf;
    }
    return res;
}

// int numFib = ReadData("Введите количество чисел Фибоначи: ");
// string line = FibNum(numFib);
// PrintResult("Числа Фибоначи: ", line);

PrintResult("Числа Фибоначи: ", FibNum(ReadData("Введите количество чисел Фибоначи: ")));



// // Анатолий
// // Создание словаря.
// Dictionary<int, double> fiboDict = new Dictionary<int, double>
// {
//     { 0, 1 },
//     { 1, 1 }
// };

// // Фибоначи рекурсия.
// double FibonachiRec(int numb, Dictionary<int, double> fiboDict)
// {
//     if (fiboDict.ContainsKey(numb))
//         return fiboDict[numb];

//     else
//     {
//         double fiboSum = FibonachiRec(numb - 2, fiboDict) + FibonachiRec(numb - 1, fiboDict);
//         fiboDict.Add(numb, fiboSum);
//         return fiboSum;
//     }
// }

// // Фибоначи цикл
// double FibonachiСycle(int numb)
// {
//     double fiboPrev = 1;
//     double fibo = 1;
//     for (int i = 2; i <= numb; i++)
//     {
//         double tmp = fibo;
//         fibo += fiboPrev;
//         fiboPrev = tmp;
//     }
//     return fibo;
// }


// int fiboNumb = 50;


// for (int i = 0; i <= fiboNumb; i++)
// {
//     Console.WriteLine($"{i} --> {FibonachiRec(i, fiboDict)}");
//     Console.WriteLine($"{i} --> {FibonachiСycle(i)}");
// }




// // int fiboNumb = 3;
// // Констнтин
// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, печатает одномерный массив
// void Print1DArray(int[] arr)
// {
//     string arrString = "";

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         arrString += arr[i] + ", ";
//     }

//     arrString += arr[arr.Length - 1];
//     Console.WriteLine(arrString);
// }

// int[] Fibonacci(int number)
// {
//     int[] fibonacciArr = new int[number];
//     fibonacciArr[1] = 1;

//     for (int i = 2; i < number; i++)
//     {
//         fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
//     }

//     return fibonacciArr;
// }

// int inputNumber = ReadData("Введите длину последовательности: ");

// Console.WriteLine($"Последовательность Фибоначчи длиной {inputNumber}:");
// Print1DArray(Fibonacci(inputNumber));



// for (int i = 0; i < fiboNumb; i++)
// {
//     //Console.WriteLine($"{i} --> {FibonachiRec(i, fiboDict)}");
//     Console.Write(FibonachiСycle(i)+" ");
// }