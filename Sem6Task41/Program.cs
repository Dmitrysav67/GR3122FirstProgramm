//------------------------------------------------------------------
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь
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
void PrintResult(int line)
{
    Console.WriteLine(line);
}

// Метод нахождения и подсчета чисел
int FindSummNum(int m)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        int a = ReadData("Введите элементы:");
        if (a > 0)
        {
            sum = sum + a; sum++;
        }
    }
    return sum;
}


int num = ReadData("Введите элементы:");
int res = FindSummNum (num);
Console.WriteLine ("Сумма элементов >0 ="+res);