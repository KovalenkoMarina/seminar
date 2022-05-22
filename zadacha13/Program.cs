int[] array = {3, 4, 5, 2, 1, 6};
int count = array.Length;
int sum = 0;
for (int i = 0; i<count; i++)
    {
        if (i%2==1)
        {
            sum = sum + array[i];
            
        }
    }
Console.Write(sum);

