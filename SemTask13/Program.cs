//------------------------------------------------------------------
// Задача 13:  Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что 
// третьей цифры нет
//-------------------------------------------------------------------
Console.WriteLine("Введите число");
string? number = Console.ReadLine();
if (number!.Length >= 3)
{
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(""+charArray[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}