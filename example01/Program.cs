int [,] myArray = new int [3, 4]
{
    {1,7,4,2},
    {5,9,2,3},
    {8,4,2,4}
};
Console.WriteLine("Это мой массив ");
//Console.Write(myArray);
for (int i = 0; i < myArray.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j]+ ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void SorTing(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < myArray.GetLength(1) - 1; z++) // цикл для сравнения и обмена
            {
                if (myArray[i, z] > myArray[i, z + 1]) //для изменения сортировки поменять знак > на противоположный
                    {
                    int temp = 0;
                    temp = myArray[i, z];
                    myArray[i, z] = myArray[i, z + 1];
                    myArray[i, z + 1] = temp;
                }
            }
        }
    }
}
SorTing(myArray);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");

void PrintArray(int[,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++) // цикл по строкам.
    {
        Console.Write("[ ");
        for (int j = 0; j < myarray.GetLength(1); j++) // цикл по столбцам.
        {
             Console.Write(myarray[i,j] + ","); 
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}
PrintArray(myArray);