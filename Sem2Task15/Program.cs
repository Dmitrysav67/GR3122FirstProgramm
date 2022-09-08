//------------------------------------------------------------------
// Задача 15:  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным
//-------------------------------------------------------------------
Console.WriteLine("Введите число");
string? inputline = Console.ReadLine();

if (inputline != null)
{
    int inputDayOfWeek = int.Parse(inputline);
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";
    bool outResult = (inputDayOfWeek == 7 || inputDayOfWeek == 6);
    Console.WriteLine(outResult+" "+"Выходной день");

    if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    {
        Console.WriteLine("Такого дня не бывает");
    }
    else Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
}  
