﻿using System;
int n, t, r, s = 0, i = 1;
System.Console.WriteLine("Enter a number:");
n=Convert.ToInt32(Console.ReadLine());
t = n;
while (i <= n)
{
    r = n % 10;
    s = s + r * r * r;
    n = n / 10;
}
if (t == s)
{
    System.Console.WriteLine("Armstorng");
}
else
{
    System.Console.WriteLine("Not Armstorng");
}