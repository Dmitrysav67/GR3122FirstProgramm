// ===========================================================
// № 8 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N
// ============================================================

Console.WriteLine("Введите число");
string? inputLineN = Console.ReadLine();
if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {

    //     int startNumber = 1;
    //     while (startNumber < inputNumberN)
    //     {
    //         if (startNumber % 2 == 0)
    //         {
    //             Console.Write(startNumber + ", ");
    //         }
    //         startNumber = startNumber + 1;
    //     }
    // }

    int startNumber = 2;
    while (startNumber < inputNumberN)
    { 
        Console.Write(startNumber + ", ");
        startNumber = startNumber + 2;
    }
    if (inputNumberN % 2 == 0)
    {
        Console.Write(inputNumberN);
    }
    }
}



