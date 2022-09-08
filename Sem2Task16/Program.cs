//------------------------------------------------------------------
//Задача 16: Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
//-------------------------------------------------------------------
Console.WriteLine("Введите первое число");
string? inputlineA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputlineB = Console.ReadLine();
if (inputlineA != null && inputlineB != null)
{
    int inputNumberA = int.Parse(inputlineA);
    int inputNumberB = int.Parse(inputlineB);
   
 bool outResult = (inputNumberA==inputNumberB*inputNumberB || inputNumberB==inputNumberA*inputNumberA);

    Console.WriteLine(outResult);
 
}
