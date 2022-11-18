// 27. Возведите число А в натуральную степень B, используя цикл.

int Step(int A, int B)
{
int i=0; int c=1;
while (i<B)
{
    c=c*A;
    i++;
}
return c;
}
int A=Convert.ToInt32(Console.ReadLine());
int B=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Step(A,B));