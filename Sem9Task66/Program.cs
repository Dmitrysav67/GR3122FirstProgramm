//------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//-------------------------------------------------------------------
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

// Сумма натуральных элементов в промежутке от M до N.
int SumRecMN(int m, int n)
{
    if (m >= n) return n;
    return m + RecMN(m + 1, n);
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

int result = SumRecMN(m, n);
PrintResult(result);