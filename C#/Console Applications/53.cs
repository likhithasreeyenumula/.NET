﻿using System;
int i, n;
System.Console.WriteLine("Enter a number:");
n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("=====================");
System.Console.WriteLine("Number \t square \t code");
System.Console.WriteLine("======================");
for(i=1;i<=n;i++)
{
    System.Console.WriteLine(i + "\t" + i * i + "\t" + i * i * i);
}
System.Console.WriteLine("======================");