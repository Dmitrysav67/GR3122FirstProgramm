//------------------------------------------------------------------
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
//-------------------------------------------------------------------
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать трёхмерного массива
void Print3DArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
         Console.WriteLine();
    }
    Console.WriteLine();
}

// Генерация случайного двумерного массива.
int[,,] Gen3DArr(int arrLen, int arrDepth,int arrHight, int arrMin, int arrMax)
{
    int[,,] arr = new int[arrLen, arrDepth, arrHight];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        for (int k = 0; k < arrDepth; k++)
        {
            arr[i,j,k] = rnd.Next(arrMin, arrMax);
        }

    }
    return arr;
}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int hight = ReadData("Введите высоту");
int[,,] arr3D = Gen3DArr(row, column, hight, 10, 99);

Print3DArray(arr3D);
