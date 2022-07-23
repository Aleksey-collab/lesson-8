int [,] myArray = new int [3,4]
{
    {1,7,4,2},
    {5,9,2,3},
    {8,4,2,4}
};
int temp = 0;
Console.WriteLine("Это наш массив ");
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        //Console.Write(myArray[i,j] + ", ");
    
    }
    
    for (int k = 0; k < myArray.GetLength(1) -1; k++)
    {
        if (myArray[i, k] > myArray[i, k + 1]) 
        {
            temp = myArray[i, k];

            myArray[i, k] = myArray[i, k + 1];

            myArray[i, k + 1] = temp;
        }
        
    }
    Console.WriteLine();

}