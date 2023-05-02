// See https://aka.ms/new-console-template for more information

int GetCountByLength(string [] myarray, int lengthLimit)
{
    int count=0;
    int i=0;
    while (i<myarray.Length)
    {
        if (myarray[i].Length <= lengthLimit) count++;
    }
    
  return count;  
}


