// ===========================================================
// № 1 Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли первое число квадратом второго
// ============================================================

Console.WriteLine("Введите первое число");
string? inputlineA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputlineB = Console.ReadLine();
if (inputlineA != null && inputlineB != null)
{
    int inputNumberA = int.Parse(inputlineA);
    int inputNumberB = int.Parse(inputlineB);

    bool outResult = (inputNumberA * inputNumberA == inputNumberB);

    Console.WriteLine(outResult);
}

