//------------------------------------------------------------------
// Задача 11: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру этого числа
//-------------------------------------------------------------------

System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(100,1000);

Console.WriteLine(number);

int ferstDigit = number/100;
int secondDigit = number%10;
Console.WriteLine(ferstDigit*10+secondDigit);



//Вариант 2
//System.Random numberGenerator = new System.Random();
//int number = numberGenerator.Next(100,1000);
//Console.WriteLine(number);
//char[] charArray = number.ToString().ToCharArray();
//Console.WriteLine(""+charArray[0]+charArray[2]);
