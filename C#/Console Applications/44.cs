﻿using System;
int n, c = 0, i = 1;
System.Console.WriteLine("Enter a number:");
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    n = n / 10;
    c = c + 1;
}
System.Console.WriteLine("count="+c);