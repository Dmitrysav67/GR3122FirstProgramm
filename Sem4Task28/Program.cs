//------------------------------------------------------------------
// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
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

int VariantMultSimple(int numA)
{
    int MultofNumber = 1;
    for (int i = 1; i <= numA; i++)
    {
        MultofNumber *= i;
    }
    return MultofNumber;
}

int numA = ReadData("Введите число:");
int res = VariantMultSimple(numA);
PrintResult("Произведение чисел равна:"+res);

