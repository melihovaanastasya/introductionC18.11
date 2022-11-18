// 31. Сгенерировать 10 случайных чисел и показать кубы тех, которые заканчиваются на четную цифру.

int r=10;
double t=r;
double x=23;
int o=(int)x; 
Random random=new Random(10);
for (int i=0;i<5;i++)
{
    int a=random.Next(1,100);
    int b=a; //(int)Math.Pow(a,3);
    if (b%2==0)
    System.Console.WriteLine($"{a}, {b}");
}
