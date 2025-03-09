using System;
int n, l = 0, f = 0, i = 1;
System.Console.WriteLine("Enter a number:");
n=Convert.ToInt32(Console.ReadLine());
l = n % 10;
while (i <= n)
{
    f = n % 10;
    n = n / 10;
}
if (f == 1)
{
    System.Console.WriteLine("cyclo");
}
else
{
    System.Console.WriteLine("Not Cyclo");
}