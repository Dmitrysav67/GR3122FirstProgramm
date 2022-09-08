//------------------------------------------------------------------
// Задача 9: Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
//-------------------------------------------------------------------

System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(10,100);

Console.WriteLine(number);

int ferstDigit = number/10;
int secondDigit = number%10;
// Вариант 1
if(ferstDigit>secondDigit)
{
    Console.WriteLine(ferstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}

//Вариант 2
   // Console.WriteLine((ferstDigit>secondDigit)? ferstDigit : secondDigit);

//Вариант 3
  //  char[] charArray = number.ToString().ToCharArray();
// Console.WriteLine(((int)charArray[0]>(int)charArray[1])? charArray[0] : charArray[1]);
