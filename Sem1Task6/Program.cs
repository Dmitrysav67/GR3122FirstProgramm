// ===========================================================
// № 6 Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)
// ============================================================

Console.WriteLine("Введите число");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int Ostatok = inputNumber % 2;
    if (Ostatok == 0)
    {
        Console.Write("Число четное");
    }

    else
    {
        Console.Write("Число нечетное");
    }

}

