//------------------------------------------------------------------
// Задача 18: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом
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
bool PolendromTest(int number)
{
    if ((number / 10000) == (number % 10) && (number / 1000) % 10 == (number/10) % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void PrintResult(int number)
{
    Console.WriteLine(PolendromTest(number));

}

int number = ReadData("Введите пятизначное число");
PrintResult(number);
