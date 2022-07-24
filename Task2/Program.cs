Console.WriteLine("Введите индекс строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int b = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [3, 4];
void method()
{
    Console.Write(a);
    Console.Write(";");
    Console.Write(b);
    Console.Write(" -> ");
}
void method2(int m, int n)
{
if (m < 0)
{
   method();
   Console.WriteLine("Нет такого числа.");
}
else
{
    if (m < 3)
    {
        if (n < 0)
        { 
           method();
           Console.WriteLine("Нет такого числа.");
        }
        else
        {
            if (n < 4)
            {
                method();
                Console.Write(array[m,n]);
            }
            else
            {
                method();
                Console.WriteLine("Нет такого числа.");
            }
        }
    }
    else
    {
       method();
       Console.WriteLine("Нет такого числа."); 
    }
}
}
Random random = new Random ();
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
method2(a,b);