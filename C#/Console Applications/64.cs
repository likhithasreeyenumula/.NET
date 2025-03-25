using System;
int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] B = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
int[,] c = new int[3, 3];
int i, j,k;
System.Console.WriteLine();
System.Console.WriteLine("A Matrix");
System.Console.WriteLine("------------");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
        System.Console.WriteLine("\t" + A[i, j]);
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("B Matrix");
System.Console.WriteLine("-----------------");
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        System.Console.WriteLine("\t" + B[i, j]);
    }
    System.Console.WriteLine();
}
for (i = 0; i < 3; i++)
{
    for (j = 0; j < 3; j++)
    {
        for (k = 0; k < 3; k++)
        {
            c[i, j] += A[i, k] * B[k, j];
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine();
System.Console.WriteLine("---------------------------");
for (i = 0;i < 3; i++)
{
    for(j = 0;j < 3; j++)
    {
        System.Console.WriteLine("\t" + c[i,j]);
    }
    System.Console.WriteLine();
}