int[] array = {3, 4, 5, 2, 1, 6};
void chang(int[] array)
{
    int count = array.Length;
    for (int i = 0; i<count; i++)
    {
        array[i]= - array[i];
    }
}
void Printchang(int[] array)
{
    int count = array.Length;
    for (int j = 0; j<count; j++)
    {
        Console.WriteLine($"{array[j]}");
    }
}
chang(array);
Printchang(array);