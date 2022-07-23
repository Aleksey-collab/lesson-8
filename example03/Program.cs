//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2  и   1 5 8 5 
//5 9 2 3      4 9 4 2
//8 4 2 4      7 2 2 6
//5 2 6 7      2 3 4 7

//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void RandomNumbers(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
RandomNumbers(matrix1);
RandomNumbers(matrix2);
int[,] matrix3 = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1 * 2");
PrintArray(matrix3);