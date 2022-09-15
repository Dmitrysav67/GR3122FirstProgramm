//------------------------------------------------------------------
// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А
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

int VariantSumSimple(int numA)
{
    int SumofNumber = 0;
    for (int i = 1; i <= numA; i++)
    {
        SumofNumber += i;
    }
    return SumofNumber;
}
int VariantSumGausa(int numA)
{
    int SumofNumber = 0;
    SumofNumber= ((1+numA)*numA)/2;
    return SumofNumber;
}

int numA = ReadData("Введите число:");
int res1 = VariantSumSimple(numA);
int res2 = VariantSumGausa(numA);
PrintResult("Сумма чисел равна:"+res1);
PrintResult("Сумма чисел равна:"+res2);