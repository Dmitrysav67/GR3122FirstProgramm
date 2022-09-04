// ===========================================================
// № 4 Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел
// ============================================================

Console.WriteLine("Введите первое число");
string? inputlineA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputlineB = Console.ReadLine();
Console.WriteLine("Введите третье число");
string? inputlineС = Console.ReadLine();
if (inputlineA != null)
    if (inputlineB != null)
        if (inputlineС != null)
        {
            int inputNumberA = int.Parse(inputlineA);
            int inputNumberB = int.Parse(inputlineB);
            int inputNumberC = int.Parse(inputlineС);

            if (inputNumberA > inputNumberB)
            {
                if (inputNumberA > inputNumberC)
                {
                    Console.WriteLine(inputNumberA);
                }
                else Console.WriteLine(inputNumberC);
            }
            else
            {
                if (inputNumberB > inputNumberC)
                {
                    Console.WriteLine(inputNumberB);
                }
                else Console.WriteLine(inputNumberC);
            }
        }


