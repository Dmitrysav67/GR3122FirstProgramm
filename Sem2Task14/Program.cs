//------------------------------------------------------------------
//Задача 14: Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
//-------------------------------------------------------------------

Console.WriteLine("Введите число");
string? inputNumber = Console.ReadLine();
if (inputNumber != null)
{
    int inpuNumber = int.Parse(inputNumber);
    
    bool outResult = (inpuNumber%7==0 && inpuNumber%23==0);

    Console.WriteLine(outResult);
}

