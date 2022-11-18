// 27. Возведите число А в натуральную степень B, используя цикл.

int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
int i=0;int c=1;
while (i<B)
{
    c=c*A;
    i++;
}
System.Console.Write(c);