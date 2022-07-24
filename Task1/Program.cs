Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m, n];
Random random = new Random ();
for (int i = 0; i < m; i++)
{ 
    for (int j = 0; j < n; j++)
    { 
        array[i,j] = random.Next(-100,100) / 10.0;
        Console.Write(array[i,j]);
        Console.Write("; ");
    }   
    Console.WriteLine();
}