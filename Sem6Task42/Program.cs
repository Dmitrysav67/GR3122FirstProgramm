//------------------------------------------------------------------
// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
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

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix+data);
}

// Метод преобразования числа
string DecToBin (int number)
{
    string binNumber = "";
    while (number>0)
    {
        binNumber=number%2+binNumber;
        number=number/2;
    }
    return binNumber;
}

int inputNumber = ReadData("Введите число:");

PrintResult("Исходное число в бинарном формате:", DecToBin(inputNumber));
