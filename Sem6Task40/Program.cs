//------------------------------------------------------------------
// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
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

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

bool TriangleTest (int a, int b, int c)
{
    return (a+b>c)&&(b+c>a)&&(c+a>b); 
}

int a = ReadData ("Введите сторону а");
int b = ReadData ("Введите сторону b");
int c = ReadData ("Введите сторону c");
PrintResult (TriangleTest(a,b,c)? "Такой треуголььник существует":"Такой треугольник не существует");