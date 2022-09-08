//------------------------------------------------------------------
//Задача 12: Напишите программу, которая будет принимать на вход два 
//числа и выводить, является ли второе число кратным первому. Если второе
//число некратно первому, то программа выводит остаток от деления.
//-------------------------------------------------------------------

Console.WriteLine("Введите первое число");
string? inputlineA = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inputlineB = Console.ReadLine();
if (inputlineA != null && inputlineB != null)
{
    double inputNumberA = double.Parse(inputlineA);
    double inputNumberB = double.Parse(inputlineB);
 if ((inputNumberB/inputNumberA)%1==0)
 {
    Console.WriteLine("Второе число является кратным первому");
 }
 else
 {
    Console.WriteLine((inputNumberB/inputNumberA)%1);
 }

}
