Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {a} равна ");
int n = 1;
int work = 1;
while (n <= a)
{
    work= work*n;    
    n++;
}
Console.Write(work);
