//------------------------------------------------------------------
// Задача 22: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N
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

string LineNumbers(int numberN)
{
    string outLine = string.Empty;
    int i = 1;
    while (i < numberN)
    {
        outLine = outLine + i + "\t";
        ++i;

    }
    outLine = outLine + numberN;
    return outLine;
}

string LineSqer(int numberN)
{
    string outLine = string.Empty;
    int i = 1;
    while (i < numberN)
    {
        outLine = outLine + i*i + "\t";
        ++i;

    }
    outLine = outLine + numberN*numberN;
    return outLine;
   
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число");

string lineTop= LineNumbers (num);
string lineDown = LineSqer (num);

PrintResult(lineTop);
PrintResult(lineDown);
