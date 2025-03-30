using System;
int [,] a= new int[100, 100];
int r, c, i, j;
System.Console.WriteLine("Enter rows:");
r = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter col:");
c = Convert.ToInt32(Console.ReadLine());
for (i = 0; i < r; i++)
{
    for (j = 0; j < c; j++)
        a[i, j] = Convert.ToInt32(Console.ReadLine());
}
for (i = 0; i < r; i++)
{
    for (j = 0; j < c; j++)
        System.Console.WriteLine("\t" + a[i, j]);
    System.Console.WriteLine();
}