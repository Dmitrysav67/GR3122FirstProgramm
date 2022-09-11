//------------------------------------------------------------------
// Задача 20: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве
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
double Colculate(int x1, int x2, int y1, int y2)
{
    double res = 0;
   res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return res;
}

void PrintResult(double line)
{
    Console.WriteLine(line);
}

int x1 = ReadData("Введите x1:");
int x2 = ReadData("Введите x2:");
int y1 = ReadData("Введите координату y1:");
int y2 = ReadData("Введите координату y2:");


double res = Colculate(x1,x2,y1,y2);

PrintResult(res);