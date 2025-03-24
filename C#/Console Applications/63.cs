using System;
int[,] A = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] B= { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int i, j;
System.Console.WriteLine();
System.Console.WriteLine("Matrix");
System.Console.WriteLine("------------");
for (i = 0; i < 3; i++)
{
    for(j = 0; j < 3; j++)
        System.Console.WriteLine("\t"+A[i, j]);
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("B Matrix");
System.Console.WriteLine("-----------------");
for(i = 0;i < 3; i++)
{
    for (j = 0;j < 3; j++)
    {
        System.Console.WriteLine("\t"+A[i, j]);
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("A+B");
System.Console.WriteLine("-----------------");
for(i = 0;i<3; i++)
{
    for(j=0;j<3; j++)
    {
        System.Console.WriteLine("\t" + (A[i, j] + B[i, j]));
        System.Console.WriteLine();
    }
}