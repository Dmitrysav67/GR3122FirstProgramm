// ===========================================================
// № 2  Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее
// ============================================================

Console.WriteLine("Введите первое число");
string? inputlineA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputlineB = Console.ReadLine();
if (inputlineA != null && inputlineB != null)
{
    int inputNumberA = int.Parse(inputlineA);
    int inputNumberB = int.Parse(inputlineB);

    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine(inputNumberA+" больше "+inputNumberB);
    }

    else
    {
        Console.WriteLine(inputNumberB+" больше "+inputNumberA);
    }
}

