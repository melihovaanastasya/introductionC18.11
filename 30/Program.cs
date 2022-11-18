// 30. Написать программу вычисления произведения чисел от 1 до N

int Multip(int mul)
{
    int i=1;
    int k=1;
    while (i<=mul)
    {
        k=k*i;
        i++;
    }
    return k;
}

int mul=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Multip(mul));