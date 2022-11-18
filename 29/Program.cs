// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

int Summary(int sum)
{
    int i=0;
    while (sum>0)
    {
        i=i+sum%10;
        sum=sum/10;
    }
    return i;
}

int sum=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summary(sum));