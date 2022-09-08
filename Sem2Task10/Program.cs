//------------------------------------------------------------------
// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа
//-------------------------------------------------------------------
Console.WriteLine("Введите трехзначное число");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int ferstDigit = (inputNumber / 10) % 10;


        Console.WriteLine(ferstDigit);


    }
}