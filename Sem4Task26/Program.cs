//------------------------------------------------------------------
// Задача 26: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе
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


void PrintResult(string line)
{
    Console.WriteLine(line);
}

int CalculateDigitString(int num)
{
    string numString = num.ToString();
    return numString.Length;

}
int num = ReadData("Введите число:");
int numofDigitl = CalculateDigitString (num);
PrintResult("Количество цифр в числе:"+numofDigitl);

