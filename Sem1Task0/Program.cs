// ===========================================================
// № 0 Напишите программу, которая на вход принимает число и выдаёт 
// его квадрат (число умноженное на само себя)
// ============================================================

Console.WriteLine("Введите число");
string? inputline = Console.ReadLine();
if (inputline != null)
{
    int inputNumber = int.Parse(inputline);
    //int outNumber = inputNumber * inputNumber;
    int outNumber = (int) Math.Pow(inputNumber, 2);
    Console.WriteLine(outNumber);
}
