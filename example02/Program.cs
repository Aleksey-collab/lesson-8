// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.WriteLine("введите размер прямоугольного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[rows, columns];
FillArrayRandomNumbers(myArray);
PrintArray(myArray);
int minsum = Int32.MaxValue; // Значение этого поля постоянное означает, что пользователь не может изменить значение этого поля.
int indexLine = 0;

if(rows > columns) // квадратную матрицу: 3 на 3 и т. д.
{
    Console.WriteLine("Заменять элементы нельзя.");
    return;
}

for (int i = 0; i < myArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum = sum + myArray[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
