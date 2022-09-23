//------------------------------------------------------------------
// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем
//-------------------------------------------------------------------

// Чтение данных из консоли
double ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    double number = double.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Поиск точки пересечения
double[] PointFind(double k1, double b1, double k2, double b2)
{
    double[] outtArr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    outtArr[0] = x;
    outtArr[1] = y;
    return outtArr;
}

double k1 = ReadData("Введите k1: ");
double b1 = ReadData("Введите b1: ");
double k2 = ReadData("Введите k2: ");
double b2 = ReadData("Введите b2: ");
double[] point = PointFind(k1, b1, k2, b2);
PrintResult("Точка пересечения двух прямых: "+ point[0]+point[1]);