int n = 8;
int a = 1;
Console.WriteLine("Наш массив");
while (a<=n)
{
    int numberA = new Random().Next(1,100);
    Console.Write(numberA + " ");
    a++;
}


