// 31. Сгенерировать 10 случайных чисел и показать кубы тех, которые заканчиваются на четную цифру.

bool Test(int a)
{
    //if (a%2==0) return true; else return false;
    return a%2==0;
}

Random random=new Random(10);
for (int i=0;i<20;i++)
{
    int a=random.Next(1,100);
    int b=a; //(int)Math.Pow(a,3);
    if (Test(b))
    System.Console.WriteLine($"{a}, {b}");
}
