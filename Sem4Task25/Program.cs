//------------------------------------------------------------------
// Задача 25:  Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B
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


void PrintResult(int line)
{
    Console.WriteLine(line);
}

int Stepen(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}


int numA = ReadData("Введите число:");
int numB = ReadData("Введите число:");
int res = Stepen(numA, numB);
PrintResult(res);

