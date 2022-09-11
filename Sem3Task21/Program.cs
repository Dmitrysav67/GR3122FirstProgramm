//------------------------------------------------------------------
// Задача 21:  Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве
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
double Colculate(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
   res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)+ (z2-z1)*(z2-z1));
    return res;
}

void PrintResult(double line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите координату x1:");
int x2 = ReadData("Введите координату x2:");
int y1 = ReadData("Введите координату y1:");
int y2 = ReadData("Введите координату y2:");
int z1 = ReadData("Введите координату z1:");
int z2= ReadData ("Введите координату z2:");


double res = Colculate(x1,x2,y1,y2,z1,z2);

PrintResult(res);

