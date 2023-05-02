

// Программа создаёт массив с размером строк меньше указанной из массива строк произвольной длины.


int GetCountByLength(string[] myarray, int lengthLimit) // Возвращает количество элементов массива с длиной строк меньше или равной указанной
{
    int count = 0;
    int i = 0;
    while (i < myarray.Length)
    {
        if (myarray[i].Length <= lengthLimit) count++;
        i++;
    }


    return count;
}

string[] createArrayByLength(string[] startArray, int myLength, int lengthLimit) // Возвращает массив строк ограниченной длины, выбранных из результирующего массива
{
    string[] newArray = new string[myLength];
    int i = 0;
    int j = 0;
    while (i < startArray.Length)
    {
        if (startArray[i].Length <= lengthLimit)
        {
            newArray[j] = startArray[i];
            j++;
        }
        i++;
    }
    return newArray;
}
void printArray(string[] arrToPrint)
{
    for (int i = 0; i < arrToPrint.Length; i++)
    {
        Console.Write(" " + arrToPrint[i]);
    }
}