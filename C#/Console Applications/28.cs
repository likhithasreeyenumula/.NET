using System;
int x;
System.Console.WriteLine("Enter a value:");
x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
    if (x == 0)
        System.Console.WriteLine("Zero");
    else
        System.Console.WriteLine("Positive");
else
    System.Console.WriteLine("Negitive");