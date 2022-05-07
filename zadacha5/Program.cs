Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
if (n>99 && n<1000)
{
    Console.WriteLine("Последняя цифра ");
    Console.Write(n%10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}