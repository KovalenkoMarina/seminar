// Показать числа Фибоначчи меньше заданного числа N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "");

int firstValue  = 0;
int secondValue = 1;
int result      = 0;
Console.Write($"{firstValue} {secondValue} ");

while(result > N)
{
    result = firstValue + secondValue;
    if(result > N) break;
    Console.Write(result + " ");
    firstValue = secondValue;
    secondValue = result;
}

