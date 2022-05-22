int[] array = {3, 4, 5, 2, 1, 6};
int count = array.Length;
int a = 0;
for (int i = 0; i<count; i++)
    {
        if (array[i]== 3)
        {
            a++;
            break;
        }
    }
if (a !=0) Console.Write("yes");
else  Console.Write("no");
