int [,] array = new int [3, 4];
Random random = new Random ();
int z = 0;
int g = 0;
double sum = 0;
void method( int a, int b)
{
    while (a < 3)
    {
        sum = sum + array[a,b];
        ++a;
    }
    double sch = sum / 3;
    if (sch - Math.Round(sch) > 0.0)
    {
        Console.Write("{0,6:F2}",sch);
        
    }
    else
    {
        if (Math.Round(sch) > sch)
        {
            Console.Write("{0,6:F2}",sch);
        }
        else
        {
            Console.Write(sch);
        }
    }
}
for (int i = 0; i < 3; i++)
{ 
    for (int j = 0; j < 4; j++)
    { 
        array[i,j] = random.Next(0,100);
        Console.Write(array[i,j]);
        Console.Write("; ");
    }   
    Console.WriteLine();
}
Console.Write("-> ");
while (g < 4)
{
    method(z,g);
    sum = 0;
    Console.Write("; ");
    ++g;
}